namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM7{
    static void Main7(string []args){
    Console.WriteLine("생성자 호출 확인");
    initial2 test1 = new initial2();
    initial2 test2 = new initial2(4);
    initial2 test3 = new initial2(100, "홍길동");
    }
}
class initial2{
    static initial2(){//정적
        Console.WriteLine("initial: 클래스 로드시에 무조건 호출");
    }public initial2(){//public 생성자
        Console.WriteLine("initial: 인자값 없음");
    }public initial2(int a){//public 생성자, 오버로딩o
        Console.WriteLine("initial: 정수 받음");
    }
    public initial2(int a, string name){//public 생성자, 오버로딩o
        Console.WriteLine("initial: 정수 문자열 받음");
    }
}