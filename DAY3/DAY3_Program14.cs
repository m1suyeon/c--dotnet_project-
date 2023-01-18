namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM14
{
    partial class MyClass
    {
        public void Method1()
        {
            Console.WriteLine("첫번째 분할 클래스의 메소드를 호출합니다.");
        }
    }

    partial class MyClass
    {
        public void Method2()
        {
            Console.WriteLine("두번째 분할 클래스의 메소드를 호출합니다.");
        }
    }

    class Program
    {
        static void Main14(string[] args)
        {
            Console.WriteLine("분할 클래스 테스트");
            MyClass obj = new MyClass();
            obj.Method1();
            obj.Method2();
        }
    }
}