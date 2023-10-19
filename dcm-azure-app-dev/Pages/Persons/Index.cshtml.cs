using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using dcm_azure_app_dev.Data;

namespace dcm_azure_app_dev.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly dcm_azure_app_dev.Data.AppDbContext _context;

        public IndexModel(dcm_azure_app_dev.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Persons != null)
            {
                Person = await _context.Persons.ToListAsync();
            }
        }
    }
}
