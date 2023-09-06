using ExtraPoints_Grillino.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ExtraPoints_Grillino.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public ApplicationContext context;
        
        public IndexModel(ILogger<IndexModel> logger, ApplicationContext db)
        {
            _logger = logger;
            context = db;
        }

        public void OnGet()
        {
            
        }
    }
}