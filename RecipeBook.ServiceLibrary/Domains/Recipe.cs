using RecipeBook.ServiceLibrary.Entities;
using RecipeBook.ServiceLibrary.Repositories;

namespace RecipeBook.ServiceLibrary.Domains;

public class Recipe
// Domains are similar to 'Business Logic'
{
    public void SaveRecipe(RecipeEntity recipeEntity)
    {
        // Validate stuff

        var repository = new RecipeRepository();
        repository.SaveRecipeToDatabase(recipeEntity);
    }
    
}