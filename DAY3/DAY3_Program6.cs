namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM6{
    DAY3_PROGRAM6(){
        Console.WriteLine("DAY3_PROGRAM6: 객체 생성시 1회 수행");
    }
static void Main6(string []args){
    Console.WriteLine("생성자 호출 확인");
    initial test = new initial();
    }
}
class initial{
    private readonly int number;
    private const int number2 = 5;
    public initial(){
        number=33;
        Console.WriteLine("initial: 객체 생성 시 1회 수행.");
    }
}