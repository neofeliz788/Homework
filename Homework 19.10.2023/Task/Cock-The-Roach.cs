using System;

namespace Task
{
    public class CockTheRoach : Tale
    {
        // Дополнительные свойства
        public string GoodGuy { get; set; }
        public bool LawfulMainCharacter { get; set; }

        public double RatingScore { get; set; }

        public string OriginalLanguage { get; set; }

        // Конструкторы
        public CockTheRoach(string author, int yearPublished)
            : base("Cock-The-Roach", author, yearPublished, "Cockroach")
        {
            GoodGuy = "Sparrow";
            LawfulMainCharacter = false;
            RatingScore = 8.2;
            OriginalLanguage = "Russian";
        }

        public CockTheRoach(string author, int yearPublished, string GoodGuyName, bool lawfulMainCharacter,string originalLanguage, double ratingScore)
            : base("Cock-The-Roach", author, yearPublished, "Cockroach")
        {
            GoodGuy = GoodGuyName;
            LawfulMainCharacter = lawfulMainCharacter;
            RatingScore = ratingScore;
            OriginalLanguage = originalLanguage;
        }

        // Методы
        public override void Name()
        {
            Console.WriteLine("\nCock-The-Roach");

        }
        public override void Link()
        {
            Console.Write("\nLink: ");
            Console.WriteLine("https://ruverses.com/korney-chukovsky/cock-the-roach/4158/\n");
        }
       

        public override void Plot()
        {
            Console.WriteLine("\nIntroduction: Bears went to the hike A-riding on a bike.");
            Console.WriteLine("\nPlot: Suddenly a Titan\r\nCrawls beneath the gate —\r\nWhiskers meant to frighten,\r\nVery stiff and straight.\r\n    Cock-the-Roach\r\n        Cock-the-Roach,\r\n            Cock-the-Roach the Great!!");
            Console.WriteLine("\nEnding: They must nail it up on high\r\n    In its place to light the sky!\n");
        }

        public override void MoralLesson()
        {
            Console.WriteLine("\nMoral lesson: Sparrows are cool.\n");
        }
       
        public override void ShortInfo()
        {
            Console.WriteLine("\nShort version of 'Cock-The-Roach':");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year Published:  {YearPublished}");
            Console.WriteLine($"Main Character: {MainCharacter}\n");
        }
        public override void ExtendedInfo()
        {
            Console.WriteLine("\nExtended version of 'Cock-The-Roach':");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year Published: {YearPublished}");
            Console.WriteLine($"Main Character: {MainCharacter}");
            Console.WriteLine($"Cockroach killer name: {GoodGuy}");
            Console.WriteLine($"Lawful main character: {LawfulMainCharacter}");
            Console.WriteLine($"Original languages: {OriginalLanguage}");
            Console.WriteLine($"Rating score: {RatingScore}/10\n");
        }
        public override void Description()
        {
            Console.WriteLine("The Monster Cockroach, also known either as Giant Cockroach or Cock-The-Roach, also popularly known by its Russian name Tarakanishche (lit. 'Тараканище'), is a popular Russian children's fairy tale poem written by poet Korney Chukovsky in 1921. The poem was later published by Raduga Publishers in 1923 and is regarded as a cultural poetic heritage among Russophones. It tells the story of an overgrown cockroach who assumed power over mankind and animals by bullying and threatening them, only to fall prey to a sparrow in the end The \"Big Bad Cockroach\" with a mustache is usually regarded as satire on Joseph Stalin, although Chukovsky might have also kept in mind Grigory Zinoviev and Leon Trotsky.\n");
        }
    }
}
