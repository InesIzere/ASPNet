using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    
       


        public class InterventionController : Controller
        {
            private IList<Intervention> customer;
            public IActionResult Index()
            {
                IEnumerable<Intervention> build = null;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://rocketclevatorscustomer.herokuapp.com/api/");
                    //HTTP GET
                    var responseTask = client.GetAsync("customers");
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<IList<Intervention>>();
                        readTask.Wait();

                        customer = readTask.Result;
                    }
                    else //web api sent error response 
                    {


                        build = Enumerable.Empty<Intervention>();

                        ModelState.AddModelError(string.Empty, "Server Error Occured.Please come back later.");
                    }
                }
                return View(customer);
            }
            public ActionResult create()
            {
                return View();
            }

            [HttpPost]
            public ActionResult create(Intervention intervention)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://rocketclevatorscustomer.herokuapp.com/api/");

                    //HTTP POST
                    var postTask = client.PostAsJsonAsync<Intervention>("customers", (Intervention)customer);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }

                ModelState.AddModelError(string.Empty, "Server Error Occured.Please come back later.");

                return View(customer);
            }
        }

    
}


   
