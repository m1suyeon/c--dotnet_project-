namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM17_2{
    static void Main17_2(String []args){
        string[] name_array = {"아저씨", "김새나", "엄마", "아빠", "누나", "형", "동생", "김말아유", "홍길동", "개구리"};
        
        while(true){
            Console.WriteLine("이름 입력: ");
            string name_input=Console.ReadLine();
            int indexA = Array.IndexOf(name_array, name_input);
            
            for(int i=0;i<=10;i++){
                if(indexA==i){
                    Console.WriteLine("{0}의 위치는 {1}에 숨어있습니다.",name_input, indexA);
                    break;
                }
            }
            if(indexA==-1){
            Console.WriteLine("{0}은(는) 존재하지 않습니다.",name_input);
            break;
        }
        }

    }
}