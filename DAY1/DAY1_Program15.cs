namespace Hello_world;
public class DAY1_PROGRAM15{
    static void Main15(string[] args){        
        Console.WriteLine("당신의 c# 학점 등급은?");
        char grade =  Convert.ToChar(Console.ReadLine().ToUpper());
        switch(grade){
            case 'A' :
                Console.WriteLine("1등입니다.");
                break;
            case 'B':
                Console.WriteLine("매우 잘했어요.");
                break;
            case 'C':
                Console.WriteLine("합격입니다.");
                break;
            case 'D':
                Console.WriteLine("다시봐요~");
                break;
            default:
                Console.WriteLine("!!학점입력!!");
                break;
        }
       }
}