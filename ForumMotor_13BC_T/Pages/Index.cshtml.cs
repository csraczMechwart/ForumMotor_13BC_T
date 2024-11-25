using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ForumMotor_13BC_T.Data;
using ForumMotor_13BC_T.Models;

namespace ForumMotor_13BC_T.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ForumMotor_13BC_T.Data.ApplicationDbContext _context;

        public IndexModel(ForumMotor_13BC_T.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Category = await _context.Categories
                .Include(c => c.User).ToListAsync();
        }
    }
}
