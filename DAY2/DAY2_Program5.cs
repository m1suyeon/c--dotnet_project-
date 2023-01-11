namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM5{
    static void Main5(String []args){
    Console.WriteLine("중첩 반복문을 테스트합니다. 수 2개를 연속으로 입력하세요 : ");
        int input1 = Convert.ToInt32(Console.ReadLine());
        int input2 = Convert.ToInt32(Console.ReadLine());
        while(true){ // 무조건 실행
            Console.WriteLine("while문 반복 : {0}", input1);
            for(int x = 1; x <= input2;){ 
                Console.WriteLine("for문 반복 : {0}", x);
                x++;
                input2 += x;
                if(input2 > 10){
                    Console.WriteLine("for문 종료"); 
                    break;
                }
            }
            input1--;
        }

    }
}