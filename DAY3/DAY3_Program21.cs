namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM21
{
    static void Main21(string[] args)
    {
        Sample x= new Sample();
        x.value = "Some Value";
        Console.WriteLine("객체 삭제 전 값: {0}", x.value);
       // x=null;
        Console.WriteLine("객체 삭제 후 - null 대입 {0}", x.value);
        x.value="some Value";
        GC.Collect();
        Console.WriteLine("객체 삭제 후 -GC 적용 {0}", x.value);
    }
}

public class Sample
{
    public string value {get;set;}
}