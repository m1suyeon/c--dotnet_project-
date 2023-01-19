namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM5
{
    static void Main5(){
        private_class private_cl=new private_class();
        private_cl.public_method1();
        public_class public_cl = new public_class();
        public_cl.name="더 행복해요";
    }
}
class private_class
{
    int a=12;
    private string name="아저씨";
    private void private_method1(){
    }
    public void public_method1(){
    }
}

public class public_class
{
    internal int b=15;
    public string name="행복해요";
    private void public_method2(){
    }
}