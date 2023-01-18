namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM12
{
    static void Main12(string[] args)
    {
        University uni=new University();
        uni.Print_University();
        University.Department dep = new University.Department();
        dep.Print_Department();
    }
}

    public class University
    {
        public void Print_University()
        {
            Console.WriteLine("성결대학교 외부 Method 호출");
        }
    public class Department
        {
            public void Print_Department()
            {
                Console.WriteLine("성결대학교 내부 Method 호출");
            }
        }
    }