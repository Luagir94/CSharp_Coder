namespace Proyecto_Coder.Entities
{
    public class Product
    {
        string  _Id;
        float  _Cost;
        string  _Description;
        string  _Price;
        int  _Stock;

        public Product(string id, float cost, string description, string price, int stock)
        {
            _Id = id;
            _Cost = cost;
            _Description = description;
            _Price = price;
            _Stock = stock;
        }
    }
}
