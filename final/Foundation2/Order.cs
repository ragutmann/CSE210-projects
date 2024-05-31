using System;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    private Customer customer;
    private List<Product> products;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double TotalCost()
    {
        double total = products.Sum(product => product.TotalCost());
        double shippingCost = customer.IsUSA() ? 5 : 35;
        return total + shippingCost;
    }

    public string PackingLabel()
    {
        return string.Join("\n", products.Select(product => product.ToString()));
    }

    public string ShippingLabel()
    {
        return customer.ToString();
    }
}

