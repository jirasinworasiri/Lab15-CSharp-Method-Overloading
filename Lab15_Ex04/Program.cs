using static System.Console;

public class Program
{
    public static void Main()
    {
        var b = new Base();
        var d1 = new Derived_1();
        var d2 = new Derived_2();

        b.A();  // เรียกเมธอด A() จากคลาส Base
        d1.A(); // เรียกเมธอด A() จากคลาส Derived_1
        d2.A(); // เรียกเมธอด A() จากคลาส Derived_2
    }
}

class Base
{
    public virtual void A()
    {
        WriteLine("Base.A()"); // เมธอด A ใน Base
    }
}

class Derived_1 : Base
{
    public override void A()
    {
        WriteLine("Derived_1.A()"); // เมธอด A ใน Derived_1
    }
}

class Derived_2 : Derived_1
{
    public override void A()
    {
        WriteLine("Derived_2.A()"); // เมธอด A ใน Derived_2
    }
}
