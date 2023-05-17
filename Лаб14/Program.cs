Service a = new();
ServiceEventArgs b = new(78, "Напиши мессагу без напряга");
a.Services += a.Obr;
a.SetPrice(b);

class Service
{
    public int price = 0;
    public event Deleg Services;
    public void SetPrice(ServiceEventArgs b)
    {
        int _price = Convert.ToInt32(Console.ReadLine());
        if (_price>100)
        {
            price = _price;
        }
        Services(this, b);
    }
    public void Obr(Service obj, ServiceEventArgs obj1)
    {
        Console.WriteLine(obj.price);
        Console.WriteLine(obj1.price);
        Console.WriteLine(obj1.message);
    }
}
class ServiceEventArgs
{
    public int price;
    public string message;

    public ServiceEventArgs(int price, string message)
    {
        this.price = price;
        this.message = message;
    }
}

delegate void Deleg(Service a, ServiceEventArgs b);