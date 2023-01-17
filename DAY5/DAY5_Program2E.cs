namespace C_SHARP_PROJECT;
public class DAY5_PROGRAM2{
    static void Main2(String[] args)
    {
        int number = 0;
        Console.WriteLine("주민등록번호 13자리 입력:");
        string name = Console.ReadLine();
        string[] name_split= name.Split("-");
        int sz1 = name_split[0].Length;
        int sz2 = name_split[1].Length;
        int[] mul=new int [11];

        // Console.WriteLine("1번째 숫자는 {0}",name_split[1][0]);
        // Console.WriteLine("{0},{1}",sz1,sz2);
        
        if (sz1 == 6&&sz2 == 7){
            // for (int i = 0; i <2; i++){
            //    Console.WriteLine("변경된 문자열: " + name_split[i].Replace(" ", string.Empty));
            // }

           for(int j=0; j<=1; j++){
                for(int k=0; k<=11; k++){
                    for(int a=2; a<=9; a++){
                        mul[k]= a*name_split[j][a];
                        if(a==9){a=2;}
                        else if(a!=9){continue;}
                        Console.WriteLine("변경된 문자열: "+mul[k]);
                    }
                }
           }
           
           int sum=0;
           for(int t=1; t<=11;t++){
            sum = mul[t-1]+mul[t];
           }sum = 11-(sum%11);

           if(sum==name_split[1][7]){
                if(name_split[name_split[1][0]]=="1"||name_split[name_split[1][0]]=="3"||name_split[name_split[1][0]]=="5"||name_split[name_split[1][0]]=="7"||name_split[name_split[1][0]]=="9"){
                    Console.WriteLine("정상 주민번호 입니다. 남자");
                }
                else if(name_split[name_split[1][0]]=="2"||name_split[name_split[1][0]]=="4"||name_split[name_split[1][0]]=="6"||name_split[name_split[1][0]]=="8"||name_split[name_split[1][0]]=="0"){
                    Console.WriteLine("정상 주민번호 입니다. 여자");
                }
           }
        }

    }
}