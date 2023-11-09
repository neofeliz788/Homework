using System;

class Работник
{

    public string имя;
    public object задача;

    public string Имя
    {
        get
        {
            return имя;
        }
    }
    public object Задача
    {
        get
        {
            return задача;
        }
    }
    public Работник(string имя)
    {
        this.имя = имя;
    }
    public void Увольнение()
    {
        Console.WriteLine($"{имя} был уволен");

    }
}