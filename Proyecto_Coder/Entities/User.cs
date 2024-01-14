namespace Proyecto_Coder.Entities
{
    public class User
    {
       string  _Id;
       string  _Name;
       string  _LastName;
       string  _Email;
       string  _Password;
       string  _Username;
            
        public User(string id, string name, string lastName, string email, string password, string username)
        {
              _Id = id;
              _Name = name;
              _LastName = lastName;
              _Email = email;
              _Password = password;
              _Username = username;
         }
    }
}
