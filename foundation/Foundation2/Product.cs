public class Product{
    private string _productName;
    private int _productId;
    private int _price;
    private int _quantity;

    public Product(string name, int productId, int price, int quantity){
        _productName = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public int TotalCost(){
        int totalCost = _price * _quantity;
        return totalCost;
    }
    public string GetDetails(){
        return $"{_productName}  {_productId}";
    }
}