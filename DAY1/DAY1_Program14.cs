namespace Hello_world;
public class DAY1_PROGRAM14{
    static void Main14(string[] args){
        int x,y;
        
        Console.WriteLine("if문 예제: 첫번째 수: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("두번째 수: ");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("입력된 두수는 {0},{1}", x,y);

        if(x>y){
            Console.WriteLine("첫번째 수가 큰 수입니다.");
        }
        if(x==y){
            Console.WriteLine("같은 수입니다.");
        }
        else{
            Console.WriteLine("두번째 수가 큰 수입니다.");
        }
        }
}