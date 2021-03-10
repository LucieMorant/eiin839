using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.Json;

namespace TD3
{
    internal class Program
    {
        static readonly HttpClient client = new HttpClient();
        private static async System.Threading.Tasks.Task Main(string[] args)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://api.jcdecaux.com/vls/v1/contracts?apiKey=b20334bec126de3154d21f3a6b7b3b17e80fc131");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                List<Contract> contracts = JsonSerializer.Deserialize<List<Contract>>(responseBody);

                for (int i = 0; i < contracts.Count; i++)
                {
                    Console.WriteLine(contracts[i].name + "\n");
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);

            }
        }
    }
    
    public class Contract
    {
        public string name { get; set; }
        public string commercial_name { get; set; }
        public string[] cities { get; set; }
        public string country_code { get; set; }
    }
}
