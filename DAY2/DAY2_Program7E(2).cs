namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM7_2{
    static void Main7_2(String []args){
        int pw = 123123;
        string some;
        int count=1;
        while(true){
            int num;
                Console.WriteLine("비밀번호 입력: ");
                num=Convert.ToInt32(Console.ReadLine());
                if(num==pw){
                    Console.WriteLine("로그인 성공");
                    break;
                }
                else if(count==5){
                    Console.WriteLine("로그인 실패, 5회 제한: 현재 {0}회", count);
                    Console.WriteLine("프로그램 종료 후 재시도 해주세요");
                    break;
                }
                else{
                    Console.WriteLine("비밀번호가 틀립니다!");
                    Console.WriteLine("로그인 실패, 5회 제한: 현재 {0}회", count);
                    count++;
                }
        }
    }
}