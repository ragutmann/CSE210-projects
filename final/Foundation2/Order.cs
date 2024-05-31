using System;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double totalProductCost = products.Sum(p => p.GetTotalCost());
        double shippingCost = customer.IsInUSA() ? 5 : 35;
        return totalProductCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (var product in products)
        {
            label += $"Name: {product.name}, ID: {product.productId}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return customer.GetFullAddress();
    }
}
