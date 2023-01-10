namespace Hello_world;
public class DAY1_PROGRAM10{
    static void Main10(string[] args){
        int i = 100000;
        double d = 1.00001;
        double e = 1.00001;
        char chr = 'C';
        float flt = 0.0001f;

        Console.WriteLine("변환 전{0} 데이터 타입{1}.",d,d.GetType());
        d=i;
        Console.WriteLine("변황 후 {0} 데이터 타입{1}.", d, d.GetType());

        d=(double)i;
        Console.WriteLine("변황 후 {0} 데이터 타입{1}.",d, d.GetType());

        //i=e;
        i=(int)e;
        Console.WriteLine("반대로 변환{0}", i);

        flt=chr;
        //chr=flt;
        }
}