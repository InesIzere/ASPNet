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
            _userManager = userManager;
        }

        [Authorize]

        public IActionResult Index()

        {
            return View();

        }



        //public IActionResult Intervention()
        //{




        //    IEnumerable<Building> building = null;

        //    using (var client = new HttpClient())
        //    {

        //        client.BaseAddress = new Uri("http://localhost:5000/api/");
        //        var responseTask = client.GetAsync("buildings");
        //        responseTask.Wait();
        //        var result = responseTask.Result;


        //        if (result.IsSuccessStatusCode)
        //        {
        //            var apiResponse = result.Content.ReadAsAsync<IList<Building>>();
        //            apiResponse.Wait();
        //            building = apiResponse.Result;
        //        }

        //        else

        //        {
        //            building = Enumerable.Empty<Building>();
        //            ModelState.AddModelError(string.Empty, "Server Error Occured.Please come back later");


        //        }

        //    }


        //    return View(building);
        //}

            //foreach (Building e in objResponse3)
            //{
            //    ViewBag.BuldingController += $"<option value='{e.Id}' name='{e.Id}' >Building # {e.Id} </option>";
            //}

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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Intervention()
        {
            //string api3 = "http://localhost:5000/api/buildings/customer/{0}";
            //string data = User.Identity.Name;
            //string url3 = string.Format(api3, data);
            //Console.WriteLine(url3);

            //WebRequest request3 = (HttpWebRequest)WebRequest.Create(url3);
            //WebResponse response3 = request3.GetResponse();
            //StreamReader reader3 = new StreamReader(response3.GetResponseStream());
            //string JSON_List3 = reader3.ReadToEnd();

            //List<Building> objResponse3 = JsonConvert.DeserializeObject<List<Building>>(JSON_List3);

            //foreach (Building e in objResponse3)
            //{
            //    ViewBag.BuldingController += $"<option value='{e.Id}' name='{e.Id}' >Building # {e.Id} </option>";
            //}
            return View();
        }
        public IActionResult Products()
        {

            return View();
        }

        public void UserManager()
        {
            return;
        }
        private class CustomerUser
        {
        }

        private UserManager<CustomerUser> _userManager { get; set; }

        private readonly ProductService _productService = new ProductService();

        public ProductService ProductService => ProductService;

        private UserManager<CustomerUser> userManager { get; set; }

    }
}
