namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM16
{
    static void object_para_send(Sub_Program1 obj)
    {
        Console.WriteLine("전달받은 객체 {0}", obj);
        Console.WriteLine("변경 여부: {0}", obj.st_setget);
        obj.st_setget="함수 객체 전달 완료";
    }
    static void Main16(string[] args)
    {
        Sub_Program1 main = new Sub_Program1();
        main.st_setget = "객체의 값 설정됨";
        Sub_Program1 main2 = new Sub_Program1();
        main2 = main;
        object_para_send(main);
        object_para_send(main2);
    }
}
public class Sub_Program1
{
    public Sub_Program1(){
        st_setget = "default";
    }
    public string st_setget{get;set;}
}