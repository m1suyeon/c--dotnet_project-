namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM20
{
    static void Main20(string[] args)
    {
        Console.WriteLine("객체 인스턴스 비교하기");
        Comparison obj1 = new Comparison("admin");
        Comparison obj2 = obj1;
        Comparison obj_null=null;

        if (Object.ReferenceEquals(obj1,obj2))
        {
            Console.WriteLine("obj1과 obj2는 동일합니다.");
        }else
        {
            Console.WriteLine("obj1과 obj2는 동일하지 않습니다.");
        }
    }
}

class Comparison
{
    public string id {get;set;}
    public Comparison(string id)
    {
        this.id=id;
    }
}