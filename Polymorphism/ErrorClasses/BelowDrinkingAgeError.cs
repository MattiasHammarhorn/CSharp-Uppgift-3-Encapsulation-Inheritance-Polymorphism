namespace Polymorphism.ErrorClasses
{
    public class BelowDrinkingAgeError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to order a drink despite not being old enough. This fired an error!";
        }
    }
}
