namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM8E_1
{
    static void Main8_1(){
        Human_Teacher JOB_t = new Human_Teacher();
        Human_Student JOB_s = new Human_Student();
        Human_Workers JOB_w = new Human_Workers();
        JOB_t.Teacher();
        JOB_s.Student();
        JOB_w.Workers();
        
    }
}

public class Human
{
    public string Name="홍길동";
    public int Age=21;
    public int Heigth=183;
    public void init(){
        Console.WriteLine("{0}은 밥을 먹는다", this.Name);
        Console.WriteLine("{0}은 걷는다", this.Name);
    }
}

public class Human_Teacher : Human
{
    public string std = "국어";
    public void Teacher(){
        init();
        Console.WriteLine("{0}은 {1}공부를 한다.", this.Name, this.std);
    }
}

public class Human_Student : Human
{
    public string class_st = "2-1";
    public void Student(){
        init();
        Console.WriteLine("{0}은 {1}에서 공부를 한다.", this.Name, this.class_st);
        Console.WriteLine("{0}은 학원을 간다.", this.Name);
    }
}
public class Human_Workers : Human
{
    public string work="마케팅 부서";
    public void Workers(){
        init();
        Console.WriteLine("{0}은 {1}에서 일을 한다.", this.Name, this.work);
        Console.WriteLine("{0}은 {1}로 출근을 한다.", this.Name, this.work);
    }
}