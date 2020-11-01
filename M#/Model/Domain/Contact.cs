using MSharp;

namespace Domain
{
    public class Contact : EntityType
    {
        public Contact()
        {
            Associate<Category>("Category").Mandatory();
            String("First name").Mandatory();
            String("Last name").Mandatory();
            String("Tel").Mandatory();
            String("Email").Mandatory().Accepts(TextPattern.EmailAddress);
        }
    }
}