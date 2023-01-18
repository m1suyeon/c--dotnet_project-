namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM22
{
    static void Main22(string[] args)
    {
        Calculator op = new Calculator();
        object_init init = new object_init(op);
        op.Calculator_print_value();
    }
}

public class Calculator
{
    public void Calculator_start_menu()
    {
        Console.WriteLine("계산기 : 1. 숫자입력, 2. 더하기, 3. 빼기, 4. 곱셈, 5. 프로그램 종료");
    }
    public void Calculator_print_value()
    {
        int Value=0;
        int menu = 0;
         Console.WriteLine("메뉴 번호를 입력해주세요 :");
         menu = int.Parse(Console.ReadLine());
        int[] menu_array = {0, 0, 0};
        if(menu==1)
        {
            for(int i=0; i<=1; i++)
            {   
                Console.WriteLine("숫자 두개 입력:");
                menu_array[i]=Convert.ToInt32(Console.ReadLine());
            }
        }else if(menu==2){
            Value = menu_array[0]+menu_array[1];
            Console.WriteLine("계산 결과를 출력합니다.");
            Console.WriteLine("입력받은 인자값 더한 결과: {0}", Value);
        }else if(menu==3){
            Value = menu_array[0]-menu_array[1];
            Console.WriteLine("계산 결과를 출력합니다.");
            Console.WriteLine("입력받은 인자값 빼기 결과: {0}", Value);
        }else if(menu==4){
            Value = menu_array[0]+menu_array[1];
            Console.WriteLine("계산 결과를 출력합니다.");
            Console.WriteLine("입력받은 인자값 곱한 결과: {0}", Value);
        }else{
            Console.WriteLine("프로그램을 종료합니다.");
        }   
    }
    public void Calculator_input_value(int maenu)
    {
        
    }
}

public class object_init{
    public object_init(Calculator obj){
        Console.WriteLine("계산기 S/W를 시작합니다. (초기화 완료)");
        obj.Calculator_start_menu();
    }
}