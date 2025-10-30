using System;
class Animal{
    public virtual void makesound()
{
    Console.WriteLine("animal making sound");
}
}
class Dog: Animal{
    public override void makesound()
    {
        Console.WriteLine("dog is barking");
    }
}
 
class Cat: Animal{
    public override void makesound()
    {
        Console.WriteLine("Cat is Meowing");
    }
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
       Animal a= new Dog();
       a.makesound();
       Animal b=new Cat();
       b.makesound();
    }
}