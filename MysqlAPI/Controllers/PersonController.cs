using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MysqlAPI.Controllers{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private testContext _context;

        public PeopleController(testContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return Ok(_context.Person.ToArray());
        }
    }
}