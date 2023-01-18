namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM10
{
public static void Main10(string[] args)
    {
    Console.WriteLine("private 데이터 접근 어떻게 하나?");
    string stName="아저씨";
    admin_get3 std = new admin_get3();
    Console.WriteLine("기밀정보, 주민정보 몰래 출력{0},{1}", std.info1_set_get,std.info2_set_get);
    std.info1_set_get=stName;
    Console.WriteLine("기밀정보, 주민정보 수정 후 출력{0},{1}", std.info1_set_get,std.info2_set_get);
    Console.WriteLine(std.print());;
    }

}
class admin_get3
{
    private string info1 = "기밀정보";
    private int info2=901112;
    private int property_test{get;set;}=999999;

    public string info1_set_get
    {
        set {info1=value;}
        get {return info1;}
    }
  
    public int info2_set_get{get;}
    
    public int print()
    {
            return property_test; 
    }
}