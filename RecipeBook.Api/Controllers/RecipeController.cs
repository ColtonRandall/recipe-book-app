using Microsoft.AspNetCore.Mvc;

namespace RecipeBook.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RecipeController : ControllerBase
{
    public IActionResult AddNewRecipe(RecipeModel recipeModel)
    {
        var businessLogic = new BusinessLogic();
        businessLogic.SaveRecipe(recipeModel);
        return Ok();
    }

    public class BusinessLogic
    {
        public void SaveRecipe(RecipeModel recipeModel)
        {
            // Validate stuff

            var dataAccess = new DataAccess();
            dataAccess.SaveRecipeToDatabase(recipeModel);
            
        }
    }

    public class DataAccess
    {
        public void SaveRecipeToDatabase(RecipeModel recipeModel)
        {
            // Save to DB
        }
    }
    
    public class RecipeModel
    {
        public string Title { get; set; }
    }
    
}