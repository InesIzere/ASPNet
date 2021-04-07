using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Core_3._1.Models;
using Microsoft.AspNetCore.Authorization;



using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Identity;

using System.Text;
using System.Net;
using System.IO;

namespace Core_3._1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize]


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public async Task<IActionResult> Index()
        {
            List<Building> BuildingsList = new List<Building>();
            using (var httpClient = new HttpClient())
            {
                string api = "https://shimwerestapi.azurewebsites.net/api/buildings/{0}/building";


                string data = User.Identity.Name;
                string url3 = string.Format(api, data);

                Console.WriteLine(url3);
                using (var response = await httpClient.GetAsync(url3))

                
                
                
                {

                    string apiResponse = await response.Content.ReadAsStringAsync();
                    BuildingsList = JsonConvert.DeserializeObject<List<Building>>(apiResponse);
                }
            }
            return View(BuildingsList);



            //List<Battery> BatteriesList = new List<Battery>();
            //using (var httpClient = new HttpClient())
            //{
            //    using (var response = await httpClient.GetAsync("https://shimwerestapi.azurewebsites.net/api/batteries"))
            //    {
            //        string apiResponse = await response.Content.ReadAsStringAsync();
            //        BatteriesList = JsonConvert.DeserializeObject<List<Battery>>(apiResponse);
            //    }
            //}
            //return View(BatteriesList);




            //List<Column> ColumnsList = new List<Column>();
            //using (var httpClient = new HttpClient())
            //{
            //    using (var response = await httpClient.GetAsync("https://shimwerestapi.azurewebsites.net/api/columns"))
            //    {
            //        string apiResponse = await response.Content.ReadAsStringAsync();
            //        ColumnsList = JsonConvert.DeserializeObject<List<Column>>(apiResponse);
            //    }
            //}
            //return View(ColumnsList);


            //List<Elevator> ElevatorsList = new List<Elevator>();
            //using (var httpClient = new HttpClient())
            //{
            //    using (var response = await httpClient.GetAsync("https://shimwerestapi.azurewebsites.net/api/elevators"))
            //    {
            //        string apiResponse = await response.Content.ReadAsStringAsync();
            //        ElevatorsList = JsonConvert.DeserializeObject<List<Elevator>>(apiResponse);
            //    }
            //}
            //return View(ElevatorsList);






        }








    }
}
