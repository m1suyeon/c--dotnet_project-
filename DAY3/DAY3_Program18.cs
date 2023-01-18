namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM18
{
    static void Main18(string[] args)
    {
        Console.WriteLine("복사생성자가 없는 경우: 각 인스턴스 입력");
        Persons person1 = new Persons("홍길동", 20);
        Persons person2 = new Persons(person1.name, person1.age);
        Console.WriteLine(person1.St_Print());
        Console.WriteLine(person2.St_Print());
    }
}
class Persons
{
    public string name {get;set;}
    public int age {get;set;}
    public Persons(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public string St_Print()
    {
        return "이름: " + this.name + ", 나이: " + this.age;
    }
}