namespace Hello_world;
public class DAY1_PROGRAM6{
    static void printValue(dynamic val){
        Console.WriteLine(val.GetType());
    }
    static void Main(string[] args){
        dynamic st_end, st_end2;
        //console.WriteLine("데이터값: {0}, 데이터 타입:"+ st_end.Gettype(), st_end);
        st_end =100; st_end2=null;
        Console.WriteLine("데이터값: {0}, 데이터 타입: "+ st_end.Gettype(), st_end);
        st_end=1.1;
        Console.WriteLine("데이터값: {0}, 데이터 타입: "+ st_end.Gettype(), st_end);
        st_end="Hello";
        Console.WriteLine("데이터값: {0}, 데이터 타입: "+ st_end.Gettype(), st_end);

        printValue("helloworld!");
        printValue(1000);
        printValue(10.50);
        }

}