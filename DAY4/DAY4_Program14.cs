namespace C_SHARP_PROJECT;
class DAY4_Program14
{
    static void Main14(string []args){
        mother mo = new son1();
        bool isson = (mo is son2);

        if(isson){
            Console.WriteLine("업캐스팅");
        }else{
            Console.WriteLine("캐스팅 불가");
        }

        son1 so = (mo as son1);
        if(so!=null){
            mo=(son1)so;
            Console.WriteLine("다운 캐스팅");
        }
    }
}

public class mother{}
public class son1:mother{}
public class son2:mother{}