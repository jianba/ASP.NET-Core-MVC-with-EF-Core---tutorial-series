using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Data;
using ContosoUniversity.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.ViewComponents
{
    public class AddListValueUseByComponentController : Controller
    {
        private readonly SchoolContext _context;

        public AddListValueUseByComponentController(SchoolContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> SaveInputValue(string name)
        {
            var test = new Test
            {
                Name = name
            };

            await _context.AddAsync(test);
            await _context.SaveChangesAsync();

            return Json(new
            {
                code = 1
            });
        }
    }
}