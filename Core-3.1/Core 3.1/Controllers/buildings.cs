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
//using CustomerPortal.Areas.Identity.Data;

namespace Core_3._1.Controllers
{
    public class Buildings : Controller
    {
        public IActionResult Index()
        {
            //Get Buildings

            IEnumerable<Building> building = null;

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("http://localhost:5000/api/");
                var responseTask = client.GetAsync("buildings");
                responseTask.Wait();
                var result = responseTask.Result;


                if (result.IsSuccessStatusCode)
                {
                    var apiResponse = result.Content.ReadAsAsync<IList<Building>>();
                    apiResponse.Wait();
                    building = apiResponse.Result;
                }

                else

                {
                    building = Enumerable.Empty<Building>();
                    ModelState.AddModelError(string.Empty, "Server Error Occured.Please come back later");


                }

            }



            return View(building);


        }


    }

}
