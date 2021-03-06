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
    public class IndexModel : PageModel
    {
        private readonly Cristea_Irinel_Lab5.Data.Cristea_Irinel_Lab5Context _context;

        public IndexModel(Cristea_Irinel_Lab5.Data.Cristea_Irinel_Lab5Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.Include(b => b.Publisher).ToListAsync();
        }
    }
}
