public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} - {product.GetProductId()}\n";
        }
        return label;
    }
    public string ShippingLabel()
    {
        return $@"{_customer.GetName()}
        {_customer.GetAddress()}";
    }
    public float Total()
    {
        float total = 0;
        foreach (Product product in _products)
        {
            total += product.GetPrice();
        }
        return total;
    }
    public void AddProduct(Product product)
{
    _products.Add(product);
}
public void SetCustomer(Customer customer)
{
    _customer = customer;
}
}