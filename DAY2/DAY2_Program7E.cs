namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM7{
    static void Main7(String []args){
        int num1,num2;

        while(true){
            Console.WriteLine("더하기 출력을 위한 두수를 연속 입력 받습니다.");
            num1=Convert.ToInt32(Console.ReadLine());
            num2=Convert.ToInt32(Console.ReadLine());

            if(num1==0&&num2==0){
                break;
            }

            Console.WriteLine("두 수의 합은 {0}+{1}={2}", num1,num2,num1+num2);
        }
    }
}