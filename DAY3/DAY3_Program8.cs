namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM8{
    ~DAY3_PROGRAM8(){
        Console.WriteLine("DAY3_PROGRAM8:소멸자 호출");
    }
static void Main8(string []args){
    Console.WriteLine("생성자/소멸자 호출 확인");
    for(int i=0;i<5;i++){
        initial3 test1=new initial3(i);
        }
        GC.Collect();
    }
}
class initial3{
    public initial3(int a){// public 생성자
    int state=a;
        Console.WriteLine("initial: 인자값 {0}",state);
    }
    ~initial3(){//소멸자, 접근지정자X
        Console.WriteLine("initial: 소멸값 {0}");
    }
}