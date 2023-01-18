namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM17
{
    static void object_para_send(Sub_Program2 obj)
    {
        Console.WriteLine("전달받은 객체 {0}", obj);
        Console.WriteLine("변경 여부: {0}", obj.st_setget);
        obj.st_setget="함수 객체 전달 완료";
    }
    static void Main17(string[] args)
    {
        Sub_Program2 main = new Sub_Program2();
        Sub_Program2 main2 = main.Copy();
        main.st_setget = "1번째 객체의 값 설정됨";
        main2.st_setget = "2번째 객체의 값 설정됨";
        object_para_send(main);
        object_para_send(main2);
    }
}
public class Sub_Program2
{
    public Sub_Program2(){
        st_setget = "default";
    }
    public Sub_Program2 Copy()
    {
        return(Sub_Program2)this.MemberwiseClone();
    }
    public string st_setget{get;set;}
}