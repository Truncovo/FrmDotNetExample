using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;

using System.Web.Mvc;
using Newtonsoft.Json;

namespace FrmDotNetExample.Controllers
{
    public class AppApiController : ApiController
    {
        [System.Web.Http.AcceptVerbs("GET", "POST")]
        public IHttpActionResult Generic(string value)
        {
            string jsonFilePath = HttpContext.Current.Server.MapPath($"~/FakeApiData/{value}.json");
            if (!File.Exists(jsonFilePath))
            {
                return NotFound();
            }
            string jsonContent = System.IO.File.ReadAllText(jsonFilePath);
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");

            return ResponseMessage(response);


        }
    }
}