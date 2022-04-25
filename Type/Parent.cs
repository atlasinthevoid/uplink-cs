namespace Uplink.Type
{
    public class Parent : Type
    {
        public Entity Value;

        public Parent()
        {
            StringType = "Parent";
            Value = new();
        }
    }
}
