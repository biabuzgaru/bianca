using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using proiect.Data;
using proiect.Models;

namespace proiect.Pages.Flori
{
    public class IndexModel : PageModel
    {
        private readonly dbContext _context;

        public IndexModel(dbContext context)
        {
            _context = context;
        }

        public IList<Floare> Flori { get;set; }

        public void OnGetAsync()
        {
            Flori = _context.Floare.ToList();
        }
    }
}
