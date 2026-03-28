public class Product
{
    private string _name;
    private int _productId;
    private float _price;
    private int _stock;

    public Product(string name, int id, int price, int qty)
    {
        _name = name;
        _productId = id;
        _price = price;
        _stock = qty;
    }
    public float GetPrice()
    {
        return _price;
    }
    public int GetProductId()
    {
        return _productId;
    }
    public string GetName()
    {
        return _name;
    }
}