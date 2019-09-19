using Newtonsoft.Json;
using StoreAppWPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StoreAppWPF.APIClients
{
    public class GroupClient
    {
        public static async Task<bool> CreateGroup(Group group)
        {
            string uri = "http://localhost:62757/api/groups"; //it's better to put this kind of strings in config files
                                                                
            HttpResponseMessage responseMessage;
            using (HttpClient httpClient = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, uri)
                {
                    Content = new StringContent(JsonConvert.SerializeObject(group), UnicodeEncoding.UTF8, "application/json")
                };
                responseMessage = await httpClient.SendAsync(request);
            }
            return true;
        }

        internal async static Task<IEnumerable<Group>> GetAllGroups()
        {

            string uri = "http://localhost:62757/api/groups"; //it's better to put this kind of strings in config files
                                                                //to get rid of repetitions
            HttpResponseMessage responseMessage;
            using (HttpClient httpClient = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, uri)
                {
                };
                responseMessage = await httpClient.SendAsync(request);
            }
            //looooooooooong string, very bad practise
            return JsonConvert.DeserializeObject<List<Group>>(responseMessage.Content.ReadAsStringAsync().Result);
        }
    }
}
