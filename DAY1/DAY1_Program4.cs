namespace Hello_world;
public class DAY1_PROGRAM4{
    static void Main4(string[] args){
    int x,y,z;
    string X,Y,Z;
    x=y=z=50;
    X=Y=Z="HELLO_WORLD1 ";

    Console.WriteLine(x+y+z);
    Console.WriteLine(X,Y,Z);
    Console.WriteLine(X+"아저씨{0}"+Z);
    Console.WriteLine(X+"아저씨{0}{1}"+Z+Y);
    Console.WriteLine(X+"아저씨{1}{0}{1}"+Z+Y);
    Console.WriteLine("오늘 홍길동은 "+"{0}를"+$"{x}번 외칩니다.",X); 
    }

}