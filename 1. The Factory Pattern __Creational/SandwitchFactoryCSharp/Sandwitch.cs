using System.Collections.Generic;
namespace SandwitchFactory
{
    public abstract class Sandwitch
    {

        public Sandwitch()
        {
            CreateIngredient();
        }

        private List<Ingredient> _Ingredients = new List<Ingredient>();


        public List<Ingredient> Ingredients
        {
           get {return _Ingredients;}
        }


        public abstract void CreateIngredient();
    }
}