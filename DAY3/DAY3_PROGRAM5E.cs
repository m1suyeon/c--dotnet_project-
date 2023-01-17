namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM5E
{
public static void Main5(string[] args)
{
    student2 st = new student2();
    string[] name = new string[3];
    int[] score = new int[3];
    int menu=0;

    while(true){
      Console.WriteLine("메뉴 선택하세요 : 1. 학생 점수 입력, 2. 학생 점수 출력, 3. 프로그램 종료");
      menu = int.Parse(Console.ReadLine());
      if(menu == 1){
        st.input_score1(ref name, ref score);
      }
      else if(menu == 2){
        st.print_info(ref name, ref score);
      }
      else{
        Console.WriteLine("프로그램을 종료합니다.");
        break;
      }
    }
}
}
public class student2
{
  public void input_score1(ref string[] name, ref int[] score)
  {
  Console.WriteLine("학생 이름과 점수를 입력합니다 :");
  for(int i=0; i<3; i++)
  {
    Console.WriteLine("{0}번쨰 학생의 이름은? :", i);
    name[i] = Console.ReadLine();
    Console.WriteLine("{0}번쨰 학생의 점수는? :", i);
    score[i] = int.Parse(Console.ReadLine());
  }
  Console.WriteLine("학생 정보 입력 완료!");
  }
  
  public void print_info(ref string[] name, ref int[] score)
  {
    double avg = 0;
    for(int i=0; i<3; i++){
    Console.WriteLine("{0}번째 학생 이름 : {1}, 점수 : {2}", i, name[i], score[i]);
    avg += score[i]; 
    }
    Console.WriteLine("학생 3명의 평균 점수는 {0}점", avg/3);
  }
}