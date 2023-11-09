using System;
using System.Collections.Generic;

public class Задача
{
    public string описание { get; set; }
    public DateTime срокиВыполнения { get; set; }
    public string инициаторЗадачи { get; set; }
    public string исполнитель { get; set; }
    public СтатусЗадачи статус { get; set; }
    public List<Отчёт> отчеты { get; set; }

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
    public string ИнициаторЗадачи
    {
        get
        {
            return инициаторЗадачи;
        }
    }
    public string Исполнитель
    {
        get
        {
            return исполнитель;
        }
    }
    public СтатусЗадачи Статус
    {
        get
        {
            return статус;
        }
    }
    public List<Отчёт> Отчеты
    {
        get
        {
            return отчеты;
        }
    }
}

public enum СтатусЗадачи
{
    Назначена,
    ВРаботе,
    НаПроверке,
    Выполнена
}