using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SLE_System.Models;

using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Core_3._1.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Net;
using System.IO;
using Microsoft.Extensions.DependencyInjection;

namespace Core_3._1.Models
{
    public class ProductService
    {


        private readonly ILogger<ProductService> _logger;
        private readonly HttpClient _httpClient = new HttpClient();
        public ProductService()
        {
            var serviceProvider = new ServiceCollection()
                      .AddLogging() //<-- You were missing this
                      .BuildServiceProvider();
            _logger = serviceProvider.GetService<ILoggerFactory>()
                        .CreateLogger<ProductService>();
        }
        // // ========== Function that calls endpoint /api/Customers/id to get all the data from the customer that is logged at the portal ============
        public Customer getFullCustomerInfo(string email)
        {
            var result = _httpClient.GetAsync("http://localhost:5000/api/customers/email/" + email).Result;
            var contentBody = result.Content.ReadAsStringAsync().Result;
            var serializerSettings = new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects };
            Customer customer = JsonConvert.DeserializeObject<Customer>(contentBody);
          
            _logger.LogInformation("customer email: {}", customer.CompanyContactEmail);
            _logger.LogInformation("customer buildings: {}", customer.buildings);
            Console.WriteLine(" ============ all the CUSTOMER infos are here!!! ============ ");
            Console.WriteLine(customer.buildings.Count);
            return customer;
        }
        //------------------------------ TEST ------------------------------
        public void helloWorld() //Test
        {
            _logger.LogInformation("Hello World!!!");
            Console.WriteLine("Hello again");
        }
    }
}
