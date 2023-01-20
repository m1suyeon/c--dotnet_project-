namespace C_SHARP_PROJECT;
class DAY4_Program16
{
    static void Main(string []args){
        barrak_class tr = new barrak_class();
        tr.creat_unit();
    }
}

class terran_class
{
    public terran_class(){
        Console.WriteLine("생성자 호출: 테란 최상위 클래스");
    }
    protected int mineral=1000;

}

class barrak_class : terran_class{
    public barrak_class(){
        Console.WriteLine("생성자 호출: 배럭을 생성합니다.");
    }
    protected int mineral=150;
    public void creat_unit(){
        marine_class mr = new marine_class();
        mr.skill();
        firebat_class fr = new firebat_class();
        fr.skill();
        medic_class md = new medic_class();
        md.skill();
        ghost_class go = new ghost_class();
        go.skill();
    }
    protected virtual void skill(){
    }
}

class marine_class : barrak_class{
    public marine_class(){Console.WriteLine("생성자 호출: 마린을 생성합니다.");}
    protected int mineral=50;
    protected override void skill(){
        Console.WriteLine("스팀팩: 기본 공격 스킬");
    }
}

class firebat_class : barrak_class{
    public firebat_class(){Console.WriteLine("생성자 호출: 파이어뱃을 생성합니다.");}
    protected int mineral=100;
    protected override void skill(){
        Console.WriteLine("화염방사: 기본 공격 스킬");
    }

}

sealed class medic_class : barrak_class{
    public medic_class(){Console.WriteLine("생성자 호출: 메딕을 생성합니다.");}
    protected int mineral=100;
    sealed protected override void skill(){
        Console.WriteLine("치료: 기본 공격 스킬");
    }
}

class ghost_class : barrak_class{
    public ghost_class(){Console.WriteLine("생성자 호출: 고스트를 생성합니다.");}
    protected int mineral=100;
    protected override void skill(){
        Console.WriteLine("핵조준: 기본 공격 스킬");
    }
}