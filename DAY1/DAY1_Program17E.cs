namespace Hello_world;
public class DAY1_PROGRAM17{
    static void Main17(string[] args){        
        Console.WriteLine("현재 시간: ");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("현재 시간(분): ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("조리 시간(분): ");
        int c = Convert.ToInt32(Console.ReadLine());

        int m, m_hour;

        if(b+c>=60){
            m=a+1;
            m_hour=(b+c)-60;
            Console.WriteLine("{0}시 {1}분", m,m_hour);
        }
        else if(b+c<=60){
            Console.WriteLine("{0}시 {1}분", a,b+c);
        }
        
       }
}