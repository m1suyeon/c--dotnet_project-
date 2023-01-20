namespace C_SHARP_PROJECT;
class DAY4_Program11E
{
    static void Main11(string []args){
        Wonder_woman SM = new Wonder_woman();

    }
}

public class Meta_Human1
{
    protected virtual void Skill_1(){Console.WriteLine("채찍공격");}
    protected virtual void Skill_2(){Console.WriteLine("방패막기");}
}

public class Wonder_woman : Meta_Human1
{
    sealed protected override void Skill_1(){Console.WriteLine("불꽃 채찍");}
    protected override void Skill_2(){Console.WriteLine("방패 비껴내기  ");}
    public void get_info1(){
        base.Skill_2();
    }
}