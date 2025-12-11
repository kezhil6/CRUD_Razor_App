using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUD_Razor_App.Data;
using CRUD_Razor_App.Model;

namespace CRUD_Razor_App.Pages.Employee
{
    public class IndexModel : PageModel
    {
        private readonly CRUD_Razor_App.Data.CRUD_Razor_AppContext _context;

        public IndexModel(CRUD_Razor_App.Data.CRUD_Razor_AppContext context)
        {
            _context = context;
        }

        public IList<CRUD_Razor_App.Model.Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee.ToListAsync();
        }
    }
}
