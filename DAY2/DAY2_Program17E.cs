namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM17{
    static void Main17(String []args){
/*        int sz1,sz2,n=0;
        string s1,s2;
        Console.WriteLine("문자열 2개 입력: ");
        s1=Console.ReadLine();
        s2=Console.ReadLine();
        sz1=s1.Length;
        sz2=s2.Length;
        bool isNumeric1 = int.TryParse(s1, out n);
        bool isNumeric2 = int.TryParse(s2, out n);            

            if(sz1==4||sz1==6){
                if(int.TryParse(s1,out _)){
                    Console.WriteLine("{0}은 문자열의 길이 및 숫자 포함 검사 결과 {1}",s1,isNumeric1);
                    
                }
            }if(sz2==4||sz2==6){
                Console.WriteLine("{0}은 문자열의 길이 및 숫자 포함 검사 결과 {1}",s2,isNumeric2);
            }
            if(sz1!=4||sz1!=6||sz2!=4||sz2!=6){
                Console.WriteLine("4글자에서 6글자 사이를 입력해주세요.");
            }*/
        bool[] answer={false,false};//정수면 true 아니면 false
        int number = 0;
        Console.WriteLine("문자열 두개 입력: ");
        string[] name_split=Console.ReadLine().Split(' ');

        for(int i=0; i<2; i++){
            if (name_split[i].Length==4||name_split[i].Length==6){
                answer[i]=Int32.TryParse(name_split[i],out number);
                Console.WriteLine("{0}은 문자열의 길이 및 숫자 포함 검사 결과 {1}",name_split[i],answer[i]);
            }else{
                Console.WriteLine("{0}은 검사를 통과하지 못했습니다.",name_split[i]);
            }
        }

    }
}