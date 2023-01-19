namespace C_SHARP_PROJECT;
class DAY4_Program10:Mother{
    protected override void F2(){Console.WriteLine("재정의 된 아들 재산2");}
    static void Main10(string []args){
        DAY4_Program10 so = new DAY4_Program10();
        so.F();//할머니1 or 엄마1
        so.F2();//현재 아들 재산
        so.get_info1();//아들이 물려받은 메소드를 통해 엄마의 상위 메소드 호출
        so.get_info2();//현재 자기 자신의(아들) 상위 메소드 호출
    }
    public void get_info2(){
        base.F2();//엄마의 부모(할머니)F2 호출
    }
}
class GrandMother{
    protected virtual void F(){Console.WriteLine("원본 할머니 재산1");}
    protected virtual void F2(){Console.WriteLine("원본 할머니 재산2");}
}
class Mother:GrandMother{
    sealed protected override void F(){Console.WriteLine("엄마 재산1 제한됨");}
    protected override void F2(){Console.WriteLine("재정의된 엄마 재산2");}
    public void get_info1(){
        base.F2();
    }
}