namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM11{
    static void Main11(String []args){
        int[,] array=new int [2,3];
        Console.WriteLine("차원={0},길이={1}",array.Rank, array.Length);

        int[,] arr = new int[2,3]{{1,2,3},{4,5,6}};
        int[,] arr2=new int[,]{{1,2,3},{4,5,6}};
        int[,] arr3={{1,2,3},{4,5,6}};

        for (int i = 0;i<arr3.GetLength(0);++i){
            for(int j=0;j<arr3.GetLength(1);++j){
                arr3[i,j]=arr3[i,j]+1;
            }
        }

        foreach(int greeting in arr3)
        Console.WriteLine($"2차원 배열의 값 출력: {greeting}");
   }
}