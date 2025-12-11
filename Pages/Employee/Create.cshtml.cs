using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CRUD_Razor_App.Data;
using CRUD_Razor_App.Model;

namespace CRUD_Razor_App.Pages.Employee
{
    public class CreateModel : PageModel
    {
        private readonly CRUD_Razor_App.Data.CRUD_Razor_AppContext _context;

        public CreateModel(CRUD_Razor_App.Data.CRUD_Razor_AppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CRUD_Razor_App.Model.Employee Employee { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Employee.Add(Employee);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
