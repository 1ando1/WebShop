﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models;

namespace WebShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpGet("list")]
        public async Task<IActionResult> GetAll()
        {
            var list = new List<CategoryItemViewModel>()
            {
                new CategoryItemViewModel
                {
                    Id = 1,
                    Name = "Series",
                    Image = "/images/1.jpg"
                },
                new CategoryItemViewModel
                {
                    Id = 2,
                    Name = "Clothes",
                    Image = "/images/2.jpg"
                },
                new CategoryItemViewModel
                {
                    Id = 3,
                    Name = "Series",
                    Image = "/images/3.jpg"
                }
            };

            return Ok(list);
        }
    }
}