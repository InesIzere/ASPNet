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
    public class Buildings
    {
        public async Task<IActionResult> Index()
        {
            List<Building> BuildingsList = new List<Building>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://shimwerestapi.azurewebsites.net/api/buildings/id"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    BuildingsList = JsonConvert.DeserializeObject<List<Building>>(apiResponse);
                }
            }



            return View();


        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }
    }

}
