using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using proiect.Models;

namespace proiect.Pages.Flori
{
    public class EditModel: PageModel
    {
        private readonly Data.dbContext _context;

        public EditModel(Data.dbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Floare Floare { get; set; }

        public PageResult OnGetAsync(int? id)
        {

            Floare = _context.Floare
                .FirstOrDefault(m => m.Id == id);
            return Page();
        }

        public RedirectToPageResult OnPostAsync(int? id)
        {

            _context.Attach(Floare).State = EntityState.Modified;

            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}
