namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM1
{
    static void Main1(String []args){
        SUB_PROGRAM SW = new SUB_PROGRAM();
        SW.init();
        SW.start();
    }
}
public class Main_Program
{
    public void init()
    {
        Console.WriteLine("프로그램의 최상위 클래스 입니다.");
    }
}

public class SUB_PROGRAM : Main_Program
{
    public void start(){
        Console.WriteLine("프로그램을 시작합니다.");
    }
    public void stop(){
        Console.WriteLine("잠시 정지합니다.");
    }
    public void attack(){
        Console.WriteLine("친구를 공격합니다.");
    }
}