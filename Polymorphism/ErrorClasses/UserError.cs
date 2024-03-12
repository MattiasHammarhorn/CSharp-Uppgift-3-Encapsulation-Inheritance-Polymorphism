namespace Polymorphism.ErrorClasses
{
    public abstract class UserError
    {
        public virtual string UEMessage()
        {
            return "Generic User Error Message!";
        }
    }
}
