using Microsoft.AspNetCore.Mvc;
using RecipeBook.Api.BusinessLogic;
using RecipeBook.Api.Models;

namespace RecipeBook.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RecipeController : ControllerBase
{
    public IActionResult AddNewRecipe(RecipeModel recipeModel)
    {
        var businessLogic = new RecipeBusinessLogic();
        businessLogic.SaveRecipe(recipeModel);
        return Ok();
    }
}