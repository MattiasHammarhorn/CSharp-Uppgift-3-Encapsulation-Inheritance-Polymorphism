namespace Encapsulation_Inheritance_Polymorphism.ErrorClasses
{
    public class TypeError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use an invalid type. This fired an error!";
        }
    }
}
