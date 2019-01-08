using Microsoft.AspNetCore.Mvc;
using SmartLibrary.Data;
using SmartLibrary.Domain;
using System.Collections.Generic;

namespace SmartLibrary.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ISmartLibraryContext _smartLibraryContext;

        public ValuesController(ISmartLibraryContext smartLibraryContext)
        {
            _smartLibraryContext = smartLibraryContext;
        }


        //ISmartLibraryContext smartLibraryContext



        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {

            _smartLibraryContext.Memebers.Add(new Member {Name = "Malia"});
               
                //======== Do not do this.=========

                //new Member
                //{
                //    Name = "Sammy",
                //    Books = new List<Book>
                //    {
                //        new Book
                //        {
                //            Tilte = "Lost Symbol"
                //        }
                //    }
                //});


              // First get thr parent object.
                              // Get the Id 

             // set the Id on the Child as a Foreing Key.

            _smartLibraryContext.Context.SaveChanges();


            return new string[] { "value1", "value2" };
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
