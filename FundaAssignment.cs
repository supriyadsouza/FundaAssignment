using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;


namespace FundaAssignment
{
    public partial class FormFundaAssignment : Form
    {
        private static string BASEURL = "http://partnerapi.funda.nl/feeds/Aanbod.svc/json/";
        private static string KEY = "005e7c1d6f6c4f9bacac16760286e3cd";
        private static string TYPE = "koop";
        private static int PAGE_SIZE = 25;
        private static int MAX_MAKELAARS = 10;

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
                generateApiRequestString("/amsterdam/sorteer-makelaar-op/"));
        }

        private void buttonPopulateMostObjectsWithTuin_Click(object sender, EventArgs e)
        {
            populateGridWithTopMakelaars(
                dataGridViewMostObjectsWithTuin, 
                generateApiRequestString("/amsterdam/tuin/sorteer-makelaar-op/"));
        }

        private string generateApiRequestString(string zoekOpdracht)
        {
            return BASEURL + KEY + "/?type=" + TYPE + "&zo=" + zoekOpdracht + "&page=1&pagesize=" + PAGE_SIZE;
        }

        private void populateGridWithTopMakelaars (DataGridView dataGridView, string apiRequestString)
        {
            dataGridView.Rows.Clear();

            Dictionary<string, int> dict_MakelaarObjects = 
                ReadFundaJson.generateDict_MakelaarObjects(apiRequestString);
            List<KeyValuePair<string, int>> sortedList_MakelaarObjects = 
                (from item in dict_MakelaarObjects orderby item.Value descending select item).ToList();
            for (int i = 0; i < Math.Min(MAX_MAKELAARS, sortedList_MakelaarObjects.Count); i++)
                dataGridView.Rows.Add(sortedList_MakelaarObjects[i].Key, sortedList_MakelaarObjects[i].Value);
        }
    }
}
