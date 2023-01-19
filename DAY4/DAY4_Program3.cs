namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM3
{
    static void Main3(){
        Cuboid cuboid = new Cuboid(3,5,7);
        Console.WriteLine($"직육면체의 부피는: {cuboid.Volume()}");
        Console.WriteLine($"직육면체의 겉넓이는: {cuboid.Perimeter()}");
    }
}
class Rectangle
{
    public int Length;
    public int Breadth;
    public int Perimeter()
    {
        return 2*(Length+Breadth);
    }
}

class Cuboid : Rectangle
{
    public int Heigth;
    public Cuboid(int l, int b, int h){
            Length=l;
            Breadth=b;
            Heigth=h;
        }
    public int Volume(){
        return Length * Breadth*Heigth;
    }
}