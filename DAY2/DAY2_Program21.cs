namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM21{
    static void Main21(String []args){
        int x=3;
        int y=6;
        int z=7;
        paramsPractice(new int[] {x,y,z});
        int[] array = paramsPractice(x,y,z);

        Console.WriteLine("PARAMS 키워드 테스트: 단순 배열 출력");
        foreach(var cnt in array){
            Console.WriteLine(cnt);
        }
    }
    public static int[] paramsPractice(params int[] array){
        return array;
    }
}