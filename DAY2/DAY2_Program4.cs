namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM4{
    static void Main4(String []args){
        Console.WriteLine("for문을 테스트합니다. 메뉴 번호를 입력해주세요 ");
        int input=Convert.ToInt32(Console.ReadLine());

        for(int x=1;x<=input;x++){
            Console.WriteLine("반복1{0}",x);
        }
        for(int x = 1; x <= input; x+=2){
            Console.WriteLine("반복2 {0}", x);
        }
        for(int x = 1; x <= input;){
            Console.WriteLine("반복3 {0}", x);
            x++;  
            if(x==5){
                break;
            }
        }

    }
}