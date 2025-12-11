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
    public class DetailsModel : PageModel
    {
        private readonly CRUD_Razor_App.Data.CRUD_Razor_AppContext _context;

        public DetailsModel(CRUD_Razor_App.Data.CRUD_Razor_AppContext context)
        {
            _context = context;
        }

        public CRUD_Razor_App.Model.Employee Employee { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee.FirstOrDefaultAsync(m => m.EmployeeId == id);

            if (employee is not null)
            {
                Employee = employee;

                return Page();
            }

            return NotFound();
        }
    }
}
