namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM3{
    static void Main3(String []args){
        int input = 0;

        while(true){
            Console.WriteLine("while문 + switc문을 테스트합니다. 메뉴 번호를 입력해주세요 ");
            Console.WriteLine("1. 출력 테스트 2. 프로그램 종료");
            input = int.Parse(Console.ReadLine());

            switch(input){
            case 1:
            Console.WriteLine("안녕하세요. 홍길동님 방갑습니다.");
            break;

            case 2:
            Console.WriteLine("프로그램을 종료합니다");
            break;

            default:
            Console.WriteLine("잘못입력");
            break;
        }
        if(input==2){
            break;
        }
        }

    }
}