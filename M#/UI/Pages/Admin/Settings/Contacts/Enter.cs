using MSharp;
using Domain;

namespace Admin.Settings.Contacts
{
    public class EnterPage : SubPage<ContactsPage>
    {
        public EnterPage()
        {
            Add<Modules.ContactForm>();
        }
    }
}