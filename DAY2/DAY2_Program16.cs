namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM16{
    static void Main16(String []args){
        string message1,message3;
        message1="오늘은 정말 아파요";
        message1=message3="오늘은 정말 아파요";
        string message2="오늘은 정말 배가 불러요?";
        string message4="HELLO_WORLD!";
        string message5="hello_world!";
        Console.WriteLine($"문자열 비교1: {string.Equals(message1,message3)}");
        Console.WriteLine($"문자열 비교2: {(message1==message3)}");
        Console.WriteLine($"문자열 비교3: {string.Compare(message1,message3)}");
        Console.WriteLine($"문자열 비교4: {string.Compare(message1,message2)}");
        Console.WriteLine($"문자열 비교5: {(message4==message5)}");
        Console.WriteLine($"문자열 비교: {(message4.Equals(message5,StringComparison.OrdinalIgnoreCase))}");

        string message_null1="";
        string message_null2=" ";
        string message_null3="\n";
        Console.WriteLine($"문자열 널 확인1: {String.IsNullOrEmpty(message_null1)}");
        Console.WriteLine($"문자열 널 확인2: {String.IsNullOrEmpty(message_null2)}");
        Console.WriteLine($"문자열 널 확인3: {String.IsNullOrWhiteSpace(message_null2)}");
        Console.WriteLine($"문자열 널 확인4: {String.IsNullOrEmpty(message_null3)}");
   }
}