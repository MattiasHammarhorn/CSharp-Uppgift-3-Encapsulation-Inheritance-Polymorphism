namespace Polymorphism.ErrorClasses
{
    public class NotEnoughSleepError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to delay your sleep for too long. This fired an error!";
        }
    }
}
