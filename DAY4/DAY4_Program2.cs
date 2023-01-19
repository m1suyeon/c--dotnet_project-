namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM2
{
    public string Name{get;set;}
    public int Age{get;set;}
    static void Main2(String []args){
        Bird 새 = new Bird();
        새.Age = 20;
        새.Age = 20;
        새.Name="훔친새";
        새.Fly();
    }
}
public class Dog: DAY4_PROGRAM2
{
    public void HowOLD()
    {
        Console.WriteLine("나이: {0}",this.Age);
    }
}

public class Bird: DAY4_PROGRAM2
{
    public void Fly(){
        Console.WriteLine("{0}살 입니다.",this.Age);
        Console.WriteLine("{0}가 날고 있어요.",this.Name);
    }
}