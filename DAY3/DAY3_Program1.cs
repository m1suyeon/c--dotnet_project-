namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM1{
    static void Main1(String []args){
        Console.WriteLine("while문을 테스트합니다. 1개의 수 입력: ");
        int input = Convert.ToInt32(Console.ReadLine());

        while(++input <= 10){
            Console.WriteLine("반복 {0}", input);
        }

        Console.WriteLine("1개의 수를 입력: ");
        input = Convert.ToInt32(Console.ReadLine());
        while(input<=10){
            Console.WriteLine("반복{0}", input);
            --input;
            if(input<0){
                break;
            }
        }
    }
}