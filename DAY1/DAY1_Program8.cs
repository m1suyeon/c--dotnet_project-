namespace Hello_world;
public class DAY1_PROGRAM8{
    static void Main8(string[] args){
        Console.WriteLine("Enter your age: ");
        int age = Console.Read();
        Console.WriteLine("Your age is: "+age);
        Console.WriteLine("Enter your birth: ");
        var birth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your birth is: "+birth);

        Console.WriteLine("아무키나 한 번 입력해주세요");
        Console.ReadKey();

        Console.WriteLine("Enter your name: ");
        string name = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Your Name is: "+name);
        }
}