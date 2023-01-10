namespace Hello_world;
public class DAY1_PROGRAM11{
    static void Main11(string[] args){
        int x = 10, y=3;
        double x2 = 10, y2=3.14;
        int result1=x+y;
        int result2=x-y;
        int result3=x*y;
        int result4=x/y;
        int result5=y/x;
        int result6=x%y;
        int result7=y%x;

        Console.WriteLine("a와 b연산 결과(정수) : 합{0} 빼기{1} 곱하기{2} 나누기{3}, {4} 나눗셈{5}, {6}", result1,result2,result3,result4,result5,result6,result7); 
        Console.WriteLine("a와 b 연산 결과(실수) : 나누기{0}, 나눗셈{1}", x2/y2, x%y);
        Console.WriteLine("a와 b 연산 결과(정수, 실수) : 곱셈{0}", x*y2);
        }
}