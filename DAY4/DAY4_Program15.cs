namespace C_SHARP_PROJECT;
class DAY4_Program15
{
    static void Main15(string []args){
        real_son2 son2 =new real_son2();
        real_son2 son3=new real_son2("홍길동");
    }
}

public class mother_end2{
    public mother_end2(){
        Console.WriteLine("어머니의 생성자 호출");
    }
    public mother_end2(string name){
        Console.WriteLine("아들의 이름은 {0}ㅁ", name);
    }
}
public class real_son1:mother_end2{
    public real_son1(){Console.WriteLine("아들a의 생성자 호출");}
    public real_son1(string name){Console.WriteLine("아들b의 이름은 {0}ㄴ",name);}
}
public class real_son2:mother_end2{
    public real_son2(){Console.WriteLine("아들1의 생성자 호출");}
    public real_son2(string name){Console.WriteLine("아들의 이름은 {0}ㄹ", name);}
}