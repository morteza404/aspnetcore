using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
       public IEnumerable<Product> GetAll(){
           return new List<Product>{
               new Product{
                   ProductId = 1,
                    Name  = "Product1",
                    Description = "This is Product1."
               },
                new Product{
                   ProductId = 2,
                    Name  = "Product2",
                    Description = "This is Product2."
               },
                new Product{
                   ProductId = 3,
                    Name  = "Product3",
                    Description = "This is Product3."
               },
               new Product{
                   ProductId = 4,
                    Name  = "Product4",
                    Description = "This is Product4."
               },
               new Product{
                   ProductId = 5,
                    Name  = "Product5",
                    Description = "This is Product5."
               },

           };

       } 
    }
}