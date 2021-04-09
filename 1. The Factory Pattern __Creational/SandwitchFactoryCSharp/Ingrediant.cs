using System.Threading;
namespace SandwitchFactory
{
    // Product
    public abstract class Ingredient
    {
         
    }


   // Concreate The Product
    public class Turkey : Ingredient
    {
        public Turkey(){
            System.Console.WriteLine("[Turkey]\n");
        }
    }
// Concreate The Product
    public class Bread : Ingredient
    {
         public Bread(){
            System.Console.WriteLine("[Bread]\n");
        }
    }
// Concreate The Product
     public class Mayonnaise  : Ingredient
    {
         public Mayonnaise(){
            System.Console.WriteLine("[Mayonnaise]\n");
        }
    }
// Concreate The Product
        public class Lettuce  : Ingredient
    {
         public Lettuce(){
            System.Console.WriteLine("[Lettuce]\n");
        }
    }

}