namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM7
{
    static void Main7(){
        SUB_PROGRAM3 SW = new SUB_PROGRAM3();
        SW.start();
    }
}
sealed class Main_Program3
{
    public void init(){
        Console.WriteLine("프로그램의 최상위 클래스입니다.");
    }
}

public class SUB_PROGRAM3// : Main_Program3 >상속안됨
{
    public void start(){
        Console.WriteLine("프로그램을 시작합니다.");
    }
}