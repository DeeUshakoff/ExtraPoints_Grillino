using ExtraPoints_Grillino.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExtraPoints_Grillino.Pages
{
    public class FoodDetailsModel : PageModel
    {
        public Food? Food { get; set; }
        public ApplicationContext context;
        private readonly ILogger<IndexModel> _logger;
        public FoodDetailsModel(ILogger<IndexModel> logger, ApplicationContext db)
        {
            _logger = logger;
            context = db;
        }

        
        public IActionResult OnGet([FromQuery(Name = "foodName")] string foodName)
        {
            Food? foundFood = context.Foods.FindAsync(foodName).Result;
            if (foundFood == null)
            {
                return Redirect("/error");
            }
            Food = foundFood;
            return Page();
        }
    }
}
