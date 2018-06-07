using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using aspnetcoreapp.Entity;
using System;
namespace aspnetcoreapp.Pages
{
    public class CustomerAdd:PageModel
    {
        private  readonly AppDbContext _db=null;
        public CustomerAdd(AppDbContext db)
        {
            _db=db;
        }

        [BindProperty]
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
           if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Customers.Add(Customer);
            await _db.SaveChangesAsync();

             return RedirectToPage("/CustomerIndex");

        }
    }
}