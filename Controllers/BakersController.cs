using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DotnetBakery.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetBakery.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // This will be the URL
    public class BakersController : ControllerBase
    {
        private readonly ApplicationContext _context; // _ means a private feild
        public BakersController(ApplicationContext context) {
            _context = context;
        }

        //Our REST API
        //GET
        // router.get
        [HttpGet] // HTTP methods
        
        public IEnumerable <Baker> GetAll(){
            Console.WriteLine("Get all bakers");

            // Must return somthing
            // return is the same as our res.send
            // only differeance no SQL
            return _context.Bakers;
        }

        //POST
        [HttpPost]
        public IActionResult Post(Baker baker) {
            
            //SQL transactions
            Console.WriteLine("in post");
            _context.Add(baker);
            _context.SaveChanges();

            //201 OK!
            return CreatedAtAction(nameof(Post), new {id = baker.id}, baker);
        }
    }
}
