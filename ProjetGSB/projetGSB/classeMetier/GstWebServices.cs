using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace projetGSB.classeMetier
{
    public class GstWebServices
    {
        // Membres privés de la classe
        private HttpClient ws;
        private string reponse;

        // Constructeur de la classe
        public GstWebServices()
        {
            ws = new HttpClient();
        }

        // Méthodes qui vont appeler les API PHP

        public async Task<List<Region>> GetAllRegionsAsync()
        {
            reponse = await ws.GetStringAsync(App.localhost + "GetAllRegions.php");
            List<Region> lesRegions = JsonConvert.DeserializeObject<List<Region>>(reponse);
            return lesRegions;
        }

        public async Task InsertRegions(string IdRegion,string sec_code,string reg_nom)
        {
            await ws.GetStringAsync(App.localhost + "InsertRegions.php?REG_CODE="+IdRegion+"&SEC_CODE="+sec_code+"&REG_NOM="+reg_nom);
        }

        public async Task<List<StatRegion>> GetNbRegionBySecteurAsync()
        {
            reponse = await ws.GetStringAsync(App.localhost + "GetNbRegionBySecteur.php");
            List<StatRegion> nbRegBySect = JsonConvert.DeserializeObject<List<StatRegion>>(reponse);
            return nbRegBySect;
        }

       public async Task<List<StatRegion>> GetRegMinAndMaxVisiteurAsync()
       {
            reponse = await ws.GetStringAsync(App.localhost + "GetRegMinAndMaxVisiteur.php");
            List<StatRegion> resultat = JsonConvert.DeserializeObject<List<StatRegion>>(reponse);
            return resultat;
       }

    }
}
