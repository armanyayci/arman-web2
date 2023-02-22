namespace arman_web2.Models
{
    public class EFContactRepository : IContactRepository
    {

        private  ApplicationDbContext _contact;
        public EFContactRepository(ApplicationDbContext contact)
        {
            _contact= contact;
        }

        public void CreateContact(Contact contact)
        {
            _contact.Contacts.Add(contact);
            _contact.SaveChanges();
        }
    }
}
