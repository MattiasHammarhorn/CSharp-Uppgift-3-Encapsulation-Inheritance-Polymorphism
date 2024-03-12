namespace Polymorphism.ErrorClasses
{
    public class TypeInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use an invalid type. This fired an error!";
        }
    }
}
