using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using TopSpotsAPI.Models;

namespace TopSpotsAPI.Controllers
{
    public class TopSpotsController : ApiController
    {
        // GET: api/TopSpots
        public IEnumerable<TopSpot> Get()
        {
            // get the file name
            string fileName = HttpContext.Current.Server.MapPath("../App_Data/topSpots.json");

            // read the context of the file into a string
            string json = File.ReadAllText(fileName);

            // convert the string into an array of objects of type TopSpot
            IEnumerable<TopSpot> topSpots = JsonConvert.DeserializeObject<IEnumerable<TopSpot>>(json);

            // return the array
            return topSpots;
        }

        // GET: api/TopSpots/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TopSpots
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TopSpots/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TopSpots/5
        public void Delete(int id)
        {
        }
    }
}
