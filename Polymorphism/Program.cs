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
            UserError ue3 = new TypeError();
            userErrors.Add(ue1);
            userErrors.Add(ue2);
            userErrors.Add(ue3);

            Console.WriteLine("\nWriting user errors:\n");
            foreach (var ue in userErrors)
            {
                Console.WriteLine(ue.UEMessage());
            }
        }
    }
}
