namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM1{
    static String admin_Name = "관리자";
    static void Main1(String []args){
        Console.WriteLine("개선된 객체지향의 세계로 오신 것을 환영");
        Console.WriteLine("학생 이름 입력: ");
        string stName = Console.ReadLine();

        student std1 = new student();
        student std2 = new student();
        std1.newMember(stName);
    }
}

class student{
    public void newMember(string name){
        Console.WriteLine("{0}학생,  반갑습니다.",name);
    }
}