namespace Hello_world;
public class DAY1_PROGRAM12{
    static void Main12(string[] args){
        int x = 10, y=3;
        double x2 = 10, y2=3.14;
        int result1=x+y;

        Console.WriteLine("a와 b연산 결과(순서대로) : 복합{0}", y + x * y2 / x2); 
        Console.WriteLine("a와 b연산 결과(우선순위 변경) : 복합{0}", (y + x) * (y2 / x2));
        Console.WriteLine("a와 b연산 결과(컴파운드 연산자) : 계산{0}", result1+=2);
        Console.WriteLine("a와 b연산 결과(증감연산자) : 계산{0}", result1++);
        Console.WriteLine("a와 b연산 결과(증감연산자) : 계산{0}", ++result1);
        Console.WriteLine("a와 b연산 결과(증감연산자) : 계산{0}, 데이터 타입{1}", ++y2,y2.GetType());
        }
}