using RecipeBook.Api.DataAccess;
using RecipeBook.Api.Models;

namespace RecipeBook.Api.BusinessLogic;

public class RecipeBusinessLogic
{
    public void SaveRecipe(RecipeModel recipeModel)
    {
        // Validate stuff

        var dataAccess = new RecipeDataAccess();
        dataAccess.SaveRecipeToDatabase(recipeModel);
    }
}