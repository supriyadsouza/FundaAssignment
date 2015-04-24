using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FundaAssignment
{
    public partial class FormFundaAssignment : Form
    {
        private static string BASEURL = "http://partnerapi.funda.nl/feeds/Aanbod.svc/json/";
        private static string KEY = "005e7c1d6f6c4f9bacac16760286e3cd";
        private static string TYPE = "koop";
        private static int PAGE_SIZE = 25;
        private static int MAX_MAKELAAR = 10;

        public FormFundaAssignment()
        {
            InitializeComponent();
            addColumnHeadersToDataGridView(dataGridViewMostObjects);
            addColumnHeadersToDataGridView(dataGridViewMostObjectsWithTuin);
        }

        private void addColumnHeadersToDataGridView(DataGridView dataGridView)
        {
            dataGridView.Columns.Add("Makelaar", "MAKELAAR");
            dataGridView.Columns.Add("Objects", "OBJECTS");
        }

        private void buttonPopulateMostObjects_Click(object sender, EventArgs e)
        {
            populateGridWithTopMakelaars(
                dataGridViewMostObjects, 
                generateApiRequest("/amsterdam/sorteer-makelaar-op/"));
        }

        private void buttonPopulateMostObjectsWithTuin_Click(object sender, EventArgs e)
        {
            populateGridWithTopMakelaars(
                dataGridViewMostObjectsWithTuin, 
                generateApiRequest("/amsterdam/tuin/sorteer-makelaar-op/"));
        }

        private void populateGridWithTopMakelaars (DataGridView dataGridView, string apiRequest)
        {
            dataGridView.Rows.Clear();

            Dictionary<string, int> fundaObjects = new Dictionary<string, int>();
            WebClient c = new WebClient();
            var data = c.DownloadString(apiRequest);
            JObject o = JObject.Parse(data);
            decimal totalApiRequests = Int32.Parse(o["Paging"]["AantalPaginas"].ToString());
            System.Threading.Thread.Sleep(10);

            for (int apiRequestNum = 1; apiRequestNum <= totalApiRequests; apiRequestNum++)
            {
                apiRequest = Regex.Replace(apiRequest, "&page=.*&", "&page=" + apiRequestNum + "&");
                data = c.DownloadString(apiRequest);
                o = JObject.Parse(data);
                for (int objectIndex = 0; objectIndex < o["Objects"].Count(); objectIndex++)
                {
                    string makelaar = o["Objects"][objectIndex]["MakelaarNaam"].ToString();
                    if (fundaObjects.ContainsKey(makelaar))
                        fundaObjects[makelaar]++;
                    else
                        fundaObjects.Add(makelaar, 1);
                }

                if (apiRequestNum % 100 == 0)
                    System.Threading.Thread.Sleep(10);
            }

            List<KeyValuePair<string, int>> sortedFundaObjects =
                (from item in fundaObjects orderby item.Value descending select item).ToList();
            for (int i = 0; i < Math.Min(MAX_MAKELAAR, sortedFundaObjects.Count); i++)
                dataGridView.Rows.Add(sortedFundaObjects[i].Key, sortedFundaObjects[i].Value);
        }

        private string generateApiRequest (string zoekOpdracht)
        {
            return BASEURL + KEY + "/?type=" + TYPE + "&zo=" + zoekOpdracht + "&page=1&pagesize=" + PAGE_SIZE;
        }
    }
}
