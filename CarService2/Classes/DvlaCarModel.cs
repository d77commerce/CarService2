using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Windows;

namespace CarService2.Classes
{
    public class DvlaCarModel
    {

        private HttpClient httpClient;

        public DvlaCarModel()
        {
            // Initialize the HttpClient in the constructor
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://driver-vehicle-licensing.api.gov.uk");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // Set your API key here (replace "REPLACE WITH YOUR API KEY" with your actual API key)
            httpClient.DefaultRequestHeaders.Add("x-api-key", "KxClq64nPc306JlOC6auj9sDVlE8cn9V63sQljDN");
        }

        public async Task<string> MakeApiRequest(string registrationNumber)
        {
            try
            {
                var endpoint = "/vehicle-enquiry/v1/vehicles";
                var data = new { registrationNumber };
                var response = await httpClient.PostAsJsonAsync(endpoint, data);

                response.EnsureSuccessStatusCode();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    MessageBox.Show("Not Found in DVLA records !");
                    return null;
                }


            }
            catch (HttpRequestException ex)
            {
                // Handle exception (e.g., show error message to the user)
                return "Error: " + ex.Message;
            }
        }
    }

}

