namespace Proyecto_Coder.Entities
{
    public class Product_Sold
    {
        string  _Id;
        string  _Id_Product;
        string  _Id_Sale;
        int _Stock;

        public Product_Sold(string id, string id_Product, string id_Sale, int stock)
        {
            _Id = id;
            _Id_Product = id_Product;
            _Id_Sale = id_Sale;
            _Stock = stock;
        }
        }
    }
}
