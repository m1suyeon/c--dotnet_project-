namespace C_SHARP_PROJECT;
class DAY4_Program12
{
    static void Main12(string []args){
        Weapon w = new Weapon();
        w.Attack();
        // Gun g = new Gun();
        // g.Attack();
        Knife k = new Knife();
        k.Attack();
    }
}

class Weapon
{
    public void Attack(){
        Console.WriteLine("기본 공격합니다.");
    }
}

class Knife : Weapon{
    public new void Attack(){
        Console.WriteLine("나이프를 휘두릅니다.");
    }
}

class Gun : Weapon{
    public void shoot(){Console.WriteLine("총을 쏩니다.");}
}