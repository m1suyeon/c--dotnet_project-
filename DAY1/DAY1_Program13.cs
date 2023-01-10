namespace Hello_world;
public class DAY1_PROGRAM13{
    static void Main13(string[] args){
        int x,y;
        Console.WriteLine("첫번째 수: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("두번째 수: ");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("입력된 정수는 {0},{1}", x,y);
        Console.WriteLine("사칙연산 결과, 더하기:{0}, 빼기:{1}, 곱셈:{2}, 나눗셈:{3}, 나머지{4}", x+y, x-y, x*y, x/y, x%y);
        }
}