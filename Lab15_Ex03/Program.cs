using static System.Console;

public class Program
{
    public static void Main()
    {
        var animalA = new Dog();
        var animalB = new Fish();
        var animalC = new Bird();

        animalA.Move();
        animalB.Move();
        animalC.Move();
    }
}

class Animal
{
    // เมธอด Move จะทำงานในคลาส Animal แต่สามารถถูก Override ในคลาสย่อยได้
    public virtual void Move()
    {
        WriteLine("Move successfully.");
    }
}

class Dog : Animal
{
    public override void Move()
    {
        WriteLine($"{this.GetType().Name}: Running on the ground.");
        // หากไม่ต้องการให้ "Move successfully." แสดงผล สามารถลบ base.Move() ออกได้
    }
}

class Fish : Animal
{
    public override void Move()
    {
        WriteLine($"{this.GetType().Name}: Swimming in the water.");
        // หากไม่ต้องการให้ "Move successfully." แสดงผล สามารถลบ base.Move() ออกได้
    }
}

class Bird : Animal
{
    public override void Move()
    {
        WriteLine($"{this.GetType().Name}: Flying in the air.");
        // หากไม่ต้องการให้ "Move successfully." แสดงผล สามารถลบ base.Move() ออกได้
    }
}
