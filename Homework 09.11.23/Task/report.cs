using System;

public class Отчёт
{
    public string текстОтчета { get; set; }
    public DateTime датаВыполнения { get; set; }
    public string исполнитель { get; set; }

    public string ТекстОтчета
    {
        get
        {
            return текстОтчета;
        }
    }
    public DateTime ДатаВыполнения
    {
        get
        {
            return датаВыполнения;
        }
    }
    public string Исполнитель
    {
        get
        {
            return исполнитель;
        }
    }
    public Отчёт(string текстОтчета, string исполнитель)
    {
        this.текстОтчета = текстОтчета;
        this.исполнитель = исполнитель;

    }
}