using System.Numerics;
using System.Reflection;

public class Order{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer){
        foreach(Product product in products){
            _products.Add(product);
        }
        _customer = customer;
    }
    public string DisplayTotalOrderCost(){
        string receipt = "\nTotal:\n------------------------------\n$";
        int total = 0;
        foreach(Product product in _products){
            total += product.TotalCost();
        }
        if(_customer.IsInUSA()){
            total += 5;
        }
        else{
            total += 35;
        }
        string subtotal = total.ToString();
        receipt += subtotal;
        return receipt;
    }
    public string GetDisplayPackingLabel(){
        string label = "Order:\n------------------------------\n";
        foreach(Product product in _products){
            label += product.GetDetails() + "\n";
        }
        return label;
    }
    public string GetDisplayShippingLabel(){
        string label = "Address:\n------------------------------\n" + _customer.GetName() + "\n" + _customer.GetDisplayAddress();
        return label;
    }
    public bool GetIsInUSA(){
        return true;
    }
}