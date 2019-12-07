using ContosoUniversity.Data;
using ContosoUniversity.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ContosoUniversity.Models.TestViewModels;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.ViewComponents
{
    public class AutoAddListValueViewComponent : ViewComponent
    {
        private readonly SchoolContext _context;

        public AutoAddListValueViewComponent(SchoolContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(
            int maxPriority, bool isDone)
        {
            string MyView = "Default";

            var items = await GetListAsync();
            return View(MyView, items);
        }

        public async Task<List<string>> GetListAsync()
        {
            return await _context.Test.Select(o => o.Name).ToListAsync();
        }
    }
}
