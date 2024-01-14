namespace Proyecto_Coder.Entities
{
    public class Sale
    {
       string _Id;
       string _Comments;
        string _Id_User;

    public Sale(string id, string comments, string id_User)
        {
          _Id = id;
          _Comments = comments;
          _Id_User = id_User;
     }
    }
}
