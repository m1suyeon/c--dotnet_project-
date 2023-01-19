namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM4
{
    static void Main4(){
        Address address = new Address("B1-3029", "BBSR", "Odisha");
        Employee employee = new Employee(1001,"Ramesh",address);
        employee.Display();
    }
}
class Address
{
    public string AddressLine, City, State;
    public Address(string addressLine, string city, string state)
    {
        AddressLine=addressLine;
        City=city;
        State=state;
    }
}

class Employee{
    public Address address;
    public int Id;
    public string Name;
    public Employee(int id, string name, Address adrs){
            Id=id;
            Name=name;
            address=adrs;
        }
    public void Display(){
                Console.WriteLine($"고용인 Id: {Id}");
                Console.WriteLine($"고용인 이름: {Name}");
                Console.WriteLine($"주소: {address.AddressLine}");
    }
}