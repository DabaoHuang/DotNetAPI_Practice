using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

//https://www.microsoft.com/net/learn/in-browser-tutorial/1

namespace dotnetAPI_PRACTICE.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            int[] books= { 2, 5, 1, 0, 0 };
            int total = 0;

            for(int i = 0; i < books.Length; i++)
            {
                if (books[i] == 2)
                {
                    total += 180;
                }
                else if (books[i] == 3)
                {
                    total += 240;
                }
                else if (books[i] > 3)
                {
                    total += (books[i] * 70);
                }
                else
                {
                    total += (books[i] * 100);
                }  // end else if
            } // end for

            //return new string[] { "value1", "value2" };
            return total;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
