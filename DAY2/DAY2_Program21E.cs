namespace C_SHARP_PROJECT;

public class DAY2_PROGRAM21_1{
    static void Main21_1(String []args){
        program_start();
    }
    static void program_start(){
        Console.WriteLine("사칙 연산에 필요한 수의 개수?");
        int num=Convert.ToInt32(Console.ReadLine());
        int[]numbers=new int[num];

        for(int i=0; i<num;i++){
            Console.WriteLine("{0}번째 데이터 입력: ",i);
            int tmp = Convert.ToInt32(Console.ReadLine());
            numbers[i] = tmp;
        }

        while(true){
            Console.WriteLine("계산기 메뉴: 1. 더하기, 2. 곱하기, 3. 종료");
            int choice=Convert.ToInt32(Console.ReadLine());

            if(choice==1){
                Console.WriteLine("더하기 결과는: {0}",sum(num, numbers));
            }else if(choice==2){
                Console.WriteLine("곱하기 결과는: {0}",product(num, numbers));
            }else{
                Console.WriteLine("프로그램을 종료합니다.");
                break;
            }
        }
    }
    static int sum(int x,int[] y){
        int tmp =0;
        for(int i=0; i<x;i++){ 
           tmp += y[i];
        }
        return tmp;
    }
    static int product(int i,int[] k){
        int tmp=1;
        for(int j=0; j<i; j++){
            tmp *= k[j];
        }
        return tmp;
    }

}