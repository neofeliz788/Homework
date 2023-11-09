using System;
using System.Collections.Generic;


public class Проект
{
    public string описание { get; set; }
    public DateTime срокиВыполнения { get; set; }
    public string инициаторПроекта { get; set; }
    public string ответственныйЗаПроект { get; set; }
    public List<Задача> задачи { get; set; }
    public СтатусПроекта статус { get; set; }

    public string Описание
    {
        get
        {
            return описание;
        }
    }
    public DateTime СрокиВыполнения
    {
        get
        {
            return срокиВыполнения;
        }
    }
    public string ИнициаторПроекта
    {
        get
        {
            return инициаторПроекта;
        }
    }
    public string ОтветственныйЗаПроект
    {
        get
        {
            return ответственныйЗаПроект;
        }
    }
    public СтатусПроекта Статус
    {
        get
        {
            return статус;
        }
    }
    public List<Задача> Задачи
    {
        get
        {
            return задачи;
        }
    }
    public Проект(string описание, string ответственныйЗаПроект, СтатусПроекта статус)
    {
        this.описание = описание;
        this.ответственныйЗаПроект = ответственныйЗаПроект;
        this.статус = статус;
    }

}

public enum СтатусПроекта
{
    Проект,
    Исполнение,
    Закрыт
}

