namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM6{
    static void Main6(String []args){
        int[] numbers = {1,2,3,5,10,15,20};
        string[]cars={"volvo","BMW","Ford","Mazda"};

        Console.WriteLine("for each.");
        foreach(int i in numbers){
            Console.WriteLine("배열의 값 출력{0}",i);
        }
        foreach(string i in cars.Reverse()){
            Console.WriteLine("배열의 값 출력{0}",i);
        }
    }
}