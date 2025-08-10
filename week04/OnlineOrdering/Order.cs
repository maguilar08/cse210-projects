using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotal()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }
        if (_customer.LivesInUsa())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += product.PackingLabel() + "\n";
        }
        return label;
    }
    public string ShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += _customer.GetName() + "\n";
        label += _customer.GetAddress();

        return label;
    }


    
}