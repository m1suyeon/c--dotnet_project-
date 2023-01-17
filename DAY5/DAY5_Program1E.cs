namespace C_SHARP_PROJECT;
public class DAY5_PROGRAM1{
    static void Main1(String []args){
        int number = 0;
        Console.WriteLine("주민등록번호 13자리 입력:");
        string[] name_split=Console.ReadLine().Split('-');

            for(int i=0; i<1; i++){
            if (name_split[i].Length==6){
                Console.WriteLine("{0}{1}",name_split[i],name_split[i+1]);
                break;
            }else{
                Console.WriteLine("다시 입력해주세요");
                }
            }

    }
}