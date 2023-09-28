using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SattaTigerTS.Entities;

namespace SattaTigerTS.WinApp.Operations
{
    class ApiOperations
    {
        public static string host = "https://satta.biz";
        public static string baseUrl;

        public ApiOperations()
        {
            baseUrl = $"{host}/api";
        }

        public ApiUser AuthenticateUser(string email, string password)
        {
            string _baseUrl = baseUrl ;
            HttpClient client = new HttpClient();
            string json = JsonConvert.SerializeObject(new
            {
                api_user =
                new
                {
                    email = email,
                    password = password
                }
            });

            //WebClient wc = new WebClient();
            //wc.Headers["Content-Type"] = "application/json";
            try
            {
                var contentData = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync($"{ApiOperations.baseUrl}/v1/login.json", contentData).Result;
                string stringJWT = response.Content.ReadAsStringAsync().Result;
                ApiUser apiUser = JsonConvert.DeserializeObject<ApiUser>(stringJWT);
                return apiUser;
        //string response = wc.UploadString(endpoint, method, json);
        //return JsonConvert.DeserializeObject<ApiUser>(response);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
