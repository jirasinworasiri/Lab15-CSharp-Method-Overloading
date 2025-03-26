using static System.Console;

public class Program
{
    public static void Main()
    {
        Derived_2 d2 = new Derived_2();

        // แปลงเป็น Base และ Derived_1
        Base b = (Base) d2;
        Derived_1 d1 = (Derived_1) d2;

        // เรียกเมธอด A() จากคลาสต่างๆ
        b.A();  // ควรแสดง "Derived_2.A()"
        d1.A(); // ควรแสดง "Derived_1.A()"
        d2.A(); // ควรแสดง "Derived_2.A()"
    }
}

class Base
{
    public virtual void A()
    {
        WriteLine("Base.A()");
    }
}

class Derived_1 : Base
{
    public override void A()  // ลบ `sealed` ออก เพื่อให้สามารถ override ใน Derived_2 ได้
    {
        WriteLine("Derived_1.A()");
    }
}

class Derived_2 : Derived_1
{
    public override void A()  // Override เมธอด A ใน Derived_2
    {
        WriteLine("Derived_2.A()");
    }
}
