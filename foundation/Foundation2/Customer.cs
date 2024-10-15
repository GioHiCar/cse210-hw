using System.Net.Sockets;

public class Customer{
    private string _name;
    private Address _address;
    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }
    public bool IsInUSA(){
        if(_address.IsInUSA()){
            return true;
        }
        return false;
    }
    public string GetName(){
        return _name;
    }
    public string GetDisplayAddress(){
        return _address.DisplayAddress();
    }
}