namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM20{
    static void Main20(String []args){
        int x=10;
        int y=5;

        int z1=Plus(x,y);//기본적인 인수 전달 방법
        int z2=Plus();//인수 기본 값 전달
        int z3=Plus(5);//인수 1개 x=5만 전달
        //int z4=Plus(,5);//인수 뒷 부분만 전달>에러
        int z4=Plus(y:10,x:-3);
        
        Console.WriteLine("두 수를 합한 결과: {0}", z1);
        Console.WriteLine("두 수를 합한 결과: {0}", z2);
        Console.WriteLine("두 수를 합한 결과: {0}", z3);
        Console.WriteLine("두 수를 합한 결과: {0}", z4);
    }
    static int Plus(int x=3,int y=5){
        return x+y;
    }
}