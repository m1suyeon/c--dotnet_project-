namespace Hello_world;
public class DAY1_PROGRAM9{
    static void Main9(string[] args){
        string St_age;
        int In_age,sum;

        Console.WriteLine("당신의 나이를 입력합니다: ");
        //St_age = Console.ReadLine(); // 기본 문자열
        //sum = St_age + 1; //에러
        In_age = Convert.ToInt32(Console.ReadLine()); // 정수로 입력
        sum = In_age + 1;
        Console.WriteLine($"첫번째 나이는 1살 더해서 {sum} 살 입니다. ");
        Console.WriteLine("결과 데이터 타입 : " + sum.GetType());

        Console.WriteLine("나이 재입력: ");
        In_age = int.Parse(Console.ReadLine()); //Convert.ToInt32과 동일
        sum = In_age + 1; 
        Console.WriteLine($"두번째 나이는 1살 더해서 {sum} 살 입니다. ");
        Console.WriteLine("결과 데이터 타입 : " + sum.ToString().GetType());

        Console.WriteLine("재입력 : ");
        Int32.TryParse(Console.ReadLine(), out In_age); //참/거짓 리턴
        sum = In_age + 1; 
        Console.WriteLine($"세번째 나이는 1살 더해서 {sum} 살 입니다. ");
        Console.WriteLine("결과 데이터 타입 : " + sum.GetType());


        }
}