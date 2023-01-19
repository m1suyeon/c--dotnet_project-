namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM8E_2
{
    static void Main8_2(){
        Super_man SM = new Super_man("홍길동",22,100,"눈에서 빔");
        Console.WriteLine( SM.public_Name);
    }
}

public class Meta_Human
{
    public string public_Name;
    protected string private_Name;
    public int Age;
    public int Power;
    public string Skill;
}

public class Super_man : Meta_Human
{
    public Super_man(string name, int age, int power,string skill){
        private_Name="클라크 켄트";
        public_Name=name;
        Age=age;
        Power=power;
        Skill=skill;
    }
}