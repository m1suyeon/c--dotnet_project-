namespace C_SHARP_PROJECT;
class DAY4_Program13
{
    static void Main13(string []args){
        Weapon2 wp = new Knife2();
        wp.Attack();
        Console.WriteLine("업캐스팅 후 데이터 타입 {0}",(wp).GetType());

        ((Knife2)wp).Attack();
        Console.WriteLine("업캐스팅 후 데이터 타입 {0}",((Knife2)wp).GetType());
        wp.Attack(new Gun2());
        // Knife2 kn = new Gun2();

        Knife2 kf = new Knife2();
        ((Weapon2)kf).Attack();
        Console.WriteLine("업캐스팅 후 데이터 타입 {0}",((Weapon2)kf).GetType());
    }
}

class Weapon2
{
    public void Attack(Gun2 gun2){
        Console.WriteLine("부모: 총을 휘둘러 공격합니다.");
    }
    public void Attack(){
        Console.WriteLine("부모: 기본 공격합니다.");
    }
}

class Knife2 : Weapon2{
    public new void Attack(){
        Console.WriteLine("자식1: 나이프로 공격합니다.");
    }
}

class Gun2 : Weapon2{
    public void shoot(){Console.WriteLine("자식2: 총을 쏩니다.");}
}