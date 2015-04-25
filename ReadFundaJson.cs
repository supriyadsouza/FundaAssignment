using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FundaAssignment
{
    class ReadFundaJson
    {
        static public Dictionary<string, int> generateDict_MakelaarObjects(String apiRequestString)
        {
            Dictionary<string, int> dict_MakelaarObjects = new Dictionary<string, int>();
            WebClient c = new WebClient();
            var data = c.DownloadString(apiRequestString);
            JObject o = JObject.Parse(data);
            decimal totalApiRequests = Int32.Parse(o["Paging"]["AantalPaginas"].ToString());
            System.Threading.Thread.Sleep(10);

            for (int apiRequestNum = 1; apiRequestNum <= totalApiRequests; apiRequestNum++)
            {
                apiRequestString = Regex.Replace(apiRequestString, "&page=.*&", "&page=" + apiRequestNum + "&");
                data = c.DownloadString(apiRequestString);
                o = JObject.Parse(data);
                for (int objectIndex = 0; objectIndex < o["Objects"].Count(); objectIndex++)
                {
                    string makelaar = o["Objects"][objectIndex]["MakelaarNaam"].ToString();
                    if (dict_MakelaarObjects.ContainsKey(makelaar))
                        dict_MakelaarObjects[makelaar]++;
                    else
                        dict_MakelaarObjects.Add(makelaar, 1);
                }

                if (apiRequestNum % 100 == 0)
                    System.Threading.Thread.Sleep(10);
            }
            return dict_MakelaarObjects;
        }
    }
}
