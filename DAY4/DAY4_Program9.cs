namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM9
{
    static void Main9(){
        END_PROGRAM SW = new END_PROGRAM();
        SW.init();
        SW.start();
    }
}
public class Start_Program
{
    public virtual void init(){//가상 메소드 정의, virtual 안쓰면 재정의 x
        Console.WriteLine("프로그램의 최상위 1등 클래스입니다.");
    }
    public void start(){//부모의 메소드는 자식 메소드에 가려짐
        Console.WriteLine("프로그램을 시작합니다.");
    }
}

public class END_PROGRAM : Start_Program
{
    public override void init(){//오버라이딩(재정의)
            Console.WriteLine("프로그램의 최상위 2등 클래스입니다.");
    }
    public new void start(){
        Console.WriteLine("프로그램을 시작합니다.");
    }
}