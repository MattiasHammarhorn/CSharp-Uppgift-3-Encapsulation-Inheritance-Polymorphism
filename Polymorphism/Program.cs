using Polymorphism.ErrorClasses;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<UserError> userErrors = new List<UserError>();
            UserError ue1 = new NumericInputError();
            UserError ue2 = new TextInputError();
            UserError ue3 = new TypeInputError();
            UserError ue4 = new BelowDrinkingAgeError();
            UserError ue5 = new NotEnoughSleepError();
            userErrors.Add(ue1);
            userErrors.Add(ue2);
            userErrors.Add(ue3);
            userErrors.Add(ue4);
            userErrors.Add(ue5);

            Console.WriteLine("Writing user errors:\n");
            foreach (var ue in userErrors)
            {
                Console.WriteLine(ue.UEMessage());
            }
        }
    }
}
