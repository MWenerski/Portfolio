using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PortfolioApp.Data;
using PortfolioApp.Models;
using System.Threading.Tasks;

namespace PortfolioApp.Pages.Projects
{
    public class CreateModel : PageModel
    {
        private readonly PortfolioContext _context;

        public CreateModel(PortfolioContext context)
        {
            _context = context;
            // Initialize Project with required properties set
            Project = new ProjectModel
            {
                Title = string.Empty, // Default or empty value
                Description = string.Empty, // Default or empty value
                GitLink = string.Empty // Default or empty value
            };
        }

        [BindProperty]
        public ProjectModel Project { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Projects.Add(Project);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}
