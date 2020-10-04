using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dovtest.MODAL;
using dovtest.DATA;
using System.Net.Http;

using System.Net.Http.Headers; 
using Newtonsoft.Json;

namespace dovtest.REPOSITORY
{
    public class CountryRepository: ICountryRepository
    {
        public async Task<object>  GetCountry(string obj) {
            var path = "https://restcountries.eu/rest/v2/regionalbloc/" + obj;
            List<Continate> res= null;
            Continate tmpobj;
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(path);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
         return responseBody;
      // return obj;
        }
    }
}