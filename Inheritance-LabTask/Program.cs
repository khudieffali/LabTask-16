using Inheritance_LabTask;

internal class Program
{
    private static void Main(string[] args)
    {
        Eagle eagle = new ("Qartal","Ag",2);
        Duck duck = new ("Ordek", "Boz", 2);
        Chicken chicken = new ("Toyuq", "Yasil", 2);

        

        eagle.Fly();
        duck.Swim();
        chicken.Walk();
    }
}