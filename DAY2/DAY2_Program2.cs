namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM2{
    static void Main2(String []args){
        Console.WriteLine("do-while문을 테스트합니다. 1개의 수 입력: ");
        int input = int.Parse(Console.ReadLine());

        do{
            Console.WriteLine("반복{0}", input);
            input++;
        }while(input<0);

        Console.WriteLine("1개의 수 입력: ");
        input=int.Parse(Console.ReadLine());
        do{
            input--;
            if(input%2==0){
                continue;
            }
            if(input<0){
            break;
            }Console.WriteLine("반복{0}", input);
        }while(input<10);
    }
}