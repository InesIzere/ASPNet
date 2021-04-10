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
using RestSharp;



namespace Core_3._1.Controllers
{
    public class Privacy : Controller
    {
        //public async Task<List<Building>> GetBuilding(long id)
        //{
        //    var url = string.Format("/api/buildings/{id}/building");
           
        //    var result = new List<Building>();
        //    var response = await client.GetAsync(url);
           
        //        if (response.IsSuccessStatusCode)
        //    {
        //        var stringResponse = await response.Content.ReadAsStringAsync();

        //        result = JsonSerializer.Deserialize<List<HolidayModel>>(stringResponse,
        //            new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        //    }
        //    else
        //    {
        //        throw new HttpRequestException(response.ReasonPhrase);
        //    }

        //    return result;
     }
}
    


