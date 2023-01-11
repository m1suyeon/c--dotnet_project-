namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM12{
    static void Main12(String []args){
        int[] array=new int [10]{4,6,11,55,34,9,12,2,1,32};
        int max, min,sum=0;

        Console.WriteLine("차원={0},길이={1}",array.Rank, array.Length);

        Array.Sort(array);
        min=array[0];
        max=array[9];
        Console.WriteLine("현재 배열의 최소 값:{0} 최대 값:{1}",min,max);

        for(int i=1;i<9;i++){
            sum += array[i];
        }
        Console.WriteLine("먹고 남은 빵의 전체 개수는 {0}개",sum);
        
   }
}