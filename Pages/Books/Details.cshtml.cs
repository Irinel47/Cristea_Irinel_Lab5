using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cristea_Irinel_Lab5.Data;
using Cristea_Irinel_Lab5.Models;

namespace Cristea_Irinel_Lab5.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Cristea_Irinel_Lab5.Data.Cristea_Irinel_Lab5Context _context;

        public DetailsModel(Cristea_Irinel_Lab5.Data.Cristea_Irinel_Lab5Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
