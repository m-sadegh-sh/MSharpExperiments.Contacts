using MSharp;
using Domain;

namespace Admin.Settings
{
    public class ContactsPage : SubPage<SettingsPage>
    {
        public ContactsPage()
        {
            Add<Modules.ContactsList>();
        }
    }
}