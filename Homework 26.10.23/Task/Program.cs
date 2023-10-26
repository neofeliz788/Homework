using Homework_26._10._23;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee semyon = new Employee("Семён", "Генеральный директор");
            Employee rashid = new Employee("Рашид", "Финансовый директор");
            Employee oIlkham = new Employee("О Ильхам", "Директор по автоматизации");
            Employee lukas = new Employee("Лукас", "Главный в бухгалтерии");
            Employee orkadiy = new Employee("Оркадий", "Начальник инф систем");
            Employee volodya = new Employee("Володя", "Зам. начальника инф систем");

            // Добавляем подчиненных
            semyon.AddSubordinate(rashid);
            semyon.AddSubordinate(oIlkham);
            rashid.AddSubordinate(lukas);
            oIlkham.AddSubordinate(orkadiy);
            oIlkham.AddSubordinate(volodya);

            // Добавляем сотрудников в отдел информационных технологий
            Employee ilshat = new Employee("Ильшат", "Главный в секторе системщиков");
            Employee ivanych = new Employee("Иваныч", "Зам. главного в секторе системщиков");
            Employee ilya = new Employee("Илья", "Системщик");
            Employee vitya = new Employee("Витя", "Системщик");
            Employee zhenya = new Employee("Женя", "Системщик");
            Employee sergey = new Employee("Сергей", "Главный в секторе разработчиков");
            Employee lyaysan = new Employee("Ляйсан", "Зам. главного в секторе разработчиков");
            Employee marat = new Employee("Марат", "Разработчик");
            Employee dina = new Employee("Дина", "Разработчик");
            Employee ildar = new Employee("Ильдар", "Разработчик");
            Employee anton = new Employee("Антон", "Разработчик");

            // Добавляем сотрудников в сектор системщиков
            orkadiy.AddSubordinate(ilshat);
            orkadiy.AddSubordinate(ivanych);
            ilshat.AddSubordinate(ilya);
            ilshat.AddSubordinate(vitya);
            ilshat.AddSubordinate(zhenya);

            // Добавляем сотрудников в сектор разработчиков
            sergey.AddSubordinate(lyaysan);
            lyaysan.AddSubordinate(marat);
            lyaysan.AddSubordinate(dina);
            lyaysan.AddSubordinate(ildar);
            lyaysan.AddSubordinate(anton);

            
            
        }
    }
}
