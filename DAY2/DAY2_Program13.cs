namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM13{
    static void Main13(String []args){
        string message1="문자열 초기화";
        string message_null = String.Empty;
        string message_start = "문자열의 시작부터 ";
        string message_end="끝까지!";

        Console.WriteLine($"문자열\t 값 출력1: {message1}");
        Console.WriteLine($"문자열 값 \'출력 2\': {message_start+message_end}");

        int number = 15;
        string message3=string.Format("숫자>문자{0}", number);
        Console.WriteLine("문자열 변환 출력3: {0}",message3);
        string time=String.Format("It is now{0:d} at{0:t}",DateTime.Now);
        string price = String.Format("Price is{0:C",512123123);
        Console.WriteLine("문자열 변환 출력4:{0}",price);
        Console.WriteLine("문자열 변환 출력4:{0}",time);

        Console.WriteLine($"문자열\t 값 출현5: {Math.PI}");
        Console.WriteLine($"문자열 \t 값 출력5: {Math.PI.ToString()}");
   }
}