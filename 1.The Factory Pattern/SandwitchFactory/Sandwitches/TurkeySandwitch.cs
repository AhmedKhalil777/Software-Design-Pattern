namespace SandwitchFactory.Sandwitches
{
    public class TurkeySandwitch : Sandwitch
    {
        public TurkeySandwitch()
        {
        }

        public override void CreateIngredient()
        {
         Ingredients.Add(new Bread());
         Ingredients.Add(new Lettuce());
         Ingredients.Add(new Mayonnaise());

         Ingredients.Add(new Turkey());
         Ingredients.Add(new Bread());

        }

    }
}