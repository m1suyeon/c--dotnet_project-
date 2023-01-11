namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM8{
    static void Main8(String []args){
        int[] number1={1,2,3,5,10,15,20};
        int[] number_size = new int[5]{1,2,4,6,8};
        int[] number2=new int[]{6,8};
        number_size[1] =100;
        number_size[0] += 100;
        string[] weekDays=new string[]{"Sun", "Mon", "Tue"};

        int count = 1;
        for(int i=0; i<number_size.Length; i++){
            Console.WriteLine("배열 출력 테스트: {0}", number_size[i]);
            Console.WriteLine("배열 출력 테스트(역): {0}", number_size[^count]);
            count++;
        }
        foreach(var number_string in number1){
            Console.WriteLine("배열 출력 테스트(for each): {0}", number_string);
        }
    }
}