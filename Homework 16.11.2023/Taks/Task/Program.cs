using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа реализует шоу <<Большие гонки>>");

            Beach beach = new Beach();
            Fishing fishing = new Fishing();
            Hill hill = new Hill();
            Mousetrap mousetrap = new Mousetrap();
            Postmen postmen = new Postmen();
            Sea sea = new Sea();

            List<IGame> games = new List<IGame>() { beach, fishing, hill, mousetrap, postmen, sea }; 

            Player Aleksandr = new Player("Александр", Countries.Россия);
            Player Anastasia = new Player("Анастасия", Countries.Россия);
            Player Anna = new Player("Анна", Countries.Россия);
            Player Victoria = new Player("Виктория", Countries.Россия);
            Player Vladimir = new Player("Владимир", Countries.Россия);
            Player Daria = new Player("Дарья", Countries.Россия);
            Player Ekaterina = new Player("Екатерина", Countries.Россия);
            Player Ivan = new Player("Иван", Countries.Россия);
            Player Irina = new Player("Ирина", Countries.Россия);
            Player Kirill = new Player("Кирилл", Countries.Россия);
            Player Konstantin = new Player("Константин", Countries.Россия);
            Player Marina = new Player("Марина", Countries.Россия);
            Player Mihail = new Player("Михаил", Countries.Россия);
            Player Nikolay = new Player("Николай", Countries.Россия);
            Player Tatiana = new Player("Татьяна", Countries.Россия);

            List<Player> Russians = new List<Player>() { Aleksandr, Anastasia, Anna, Victoria, Vladimir, Daria, Ekaterina, Ivan, Irina, Kirill, 
                Konstantin, Marina, Mihail, Nikolay, Tatiana };
            Team RussiaTeam = new Team(Countries.Россия, Russians);

            Player Anne = new Player("Анн", Countries.Франция);
            Player Bernard = new Player("Бернард", Countries.Франция);
            Player Charles = new Player("Шарль", Countries.Франция);
            Player Denis = new Player("Денис", Countries.Франция);
            Player Elodie = new Player("Элоди", Countries.Франция);
            Player Francois = new Player("Франсуа", Countries.Франция);
            Player Guillaume = new Player("Гийом", Countries.Франция);
            Player Isabelle = new Player("Изабель", Countries.Франция);
            Player Jacques = new Player("Жак", Countries.Франция);
            Player Jean = new Player("Жан", Countries.Франция);
            Player Julie = new Player("Жюли", Countries.Франция);
            Player Louis = new Player("Луи", Countries.Франция);
            Player Marie = new Player("Мари", Countries.Франция);
            Player Philippe = new Player("Филипп", Countries.Франция);
            Player Victor = new Player("Виктор", Countries.Франция);

            List<Player> French = new List<Player>() { Anne, Bernard, Charles, Denis, Elodie, Francois, Guillaume, Isabelle, Jacques, Jean, Julie, Louis,
                Marie, Philippe, Victor};
            Team FranceTeam = new Team(Countries.Франция, French);

            Player Li = new Player("Ли", Countries.Китай);
            Player Wang = new Player("Ван", Countries.Китай);
            Player Zhao = new Player("Чжао", Countries.Китай);
            Player Zhang = new Player("Чжан", Countries.Китай);
            Player Chen = new Player("Чэнь", Countries.Китай);
            Player He = new Player("Хэ", Countries.Китай);
            Player Zhou = new Player("Чжоу", Countries.Китай);
            Player Wu = new Player("У", Countries.Китай);
            Player Zheng = new Player("Чжен", Countries.Китай);
            Player Yu = new Player("Юй", Countries.Китай);
            Player Sun = new Player("Сунь", Countries.Китай);
            Player Zhu = new Player("Чжу", Countries.Китай);
            Player Fang = new Player("Фан", Countries.Китай);
            Player Shi = new Player("Ши", Countries.Китай);
            Player Luo = new Player("Ло", Countries.Китай);

            List<Player> Chinese = new List<Player>() { Li, Wang, Zhao, Zhang, Chen, He, Zhou, Wu, Zheng, Yu, Sun, Zhu, Fang, Shi, Luo };
            Team ChinaTeam = new Team(Countries.Китай, Chinese);

            Player Marlen = new Player("Марлен", Countries.Казахстан);
            Player Rasul = new Player("Расул", Countries.Казахстан);
            Player Baltabek = new Player("Балтабек", Countries.Казахстан);
            Player Daniar = new Player("Даниар", Countries.Казахстан);
            Player Askar = new Player("Аскар", Countries.Казахстан);
            Player Ruslan = new Player("Руслан", Countries.Казахстан);
            Player Dilya = new Player("Диля", Countries.Казахстан);
            Player Shara = new Player("Шара", Countries.Казахстан);
            Player Amina = new Player("Амина", Countries.Казахстан);
            Player Murat = new Player("Мурат", Countries.Казахстан);
            Player Iliyas = new Player("Ильяс", Countries.Казахстан);
            Player Amir = new Player("Амир", Countries.Казахстан);
            Player Magjan = new Player("Магжан", Countries.Казахстан);
            Player Ayan = new Player("Аян", Countries.Казахстан);
            Player Nariman = new Player("Нариман", Countries.Казахстан);

            List<Player> Kazakhs = new List<Player>() { Marlen, Rasul, Baltabek, Daniar, Askar, Ruslan, Dilya, Shara, Amina, Murat, Iliyas, Amir,
                Magjan, Ayan, Nariman};
            Team KazakhstanTeam = new Team(Countries.Казахстан, Kazakhs);

            List<Team> teams = new List<Team>() { RussiaTeam, FranceTeam, ChinaTeam, KazakhstanTeam };

            Organizer Olivier = new Organizer("Оливье Ганьян");

            BigRaceShow brs = new BigRaceShow();

            Olivier.AddGamesToBigRace(brs, games);
            Olivier.AddTeamsToBigRace(brs, teams);

            Bull bull = new Bull();

            Olivier.AddGameToBigRace(brs, bull);

            brs.Start(sea);
            brs.Start(fishing);
            brs.Start(hill);
            brs.Start(mousetrap);
            brs.Start(postmen);
            brs.Start(beach);
            brs.Start(bull);

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
