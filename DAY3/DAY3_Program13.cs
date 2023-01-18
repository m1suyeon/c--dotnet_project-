namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM13
{
    static void Main13(string[] args)
    {
        University2.Department2 outin = new University2.Department2();
        outin.Print_Department();
    }
}

    public class University2
    {
        private int pass = 123123;
        public void Print_University(int a)
        {
            Console.WriteLine("성결대학교 외부 Method 호출 {0}", a);
        }

    public class Department2
    {
        public void Print_Department()
        {
            University2 inout = new University2();
            inout.Print_University(123123);
            inout.pass = 455788;
            Console.WriteLine("성결대학교 내부>외부 값 변경 {0}", inout.pass);
            }
        }
    }