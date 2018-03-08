using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LoLDataAnalysis
{
    class SearchWrapper
    {
        readonly string API_KEY = "?api_key=RGAPI-439c1ccc-23cd-488c-a1b8-2d1247f789dd";
        readonly string API_ENTRY_STATIC = "https://na1.api.riotgames.com/lol/static-data/";
        readonly string VERSION = "v3/";
        readonly string CHAMPIONS = "champions/";
        readonly string LOCALE_NA = "en_US";


        public string GetChampion(int id) {
            string searchURL = API_ENTRY_STATIC + VERSION + CHAMPIONS + id + API_KEY + SearchParams.CHAMP_DATA_ALL + SearchParams.TAGS_ALL;
            WebClient webClient = new WebClient();
            string response;
            try {
                response = webClient.DownloadString(searchURL);
            }
            catch { response = "error"; }
            return response;
        }
    }

    class SearchParams {
        public static readonly string CHAMP_DATA_ALL = "&champData=all";
        public static readonly string TAGS_ALL = "&tags=all";
    }
}
