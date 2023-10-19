using System;

namespace Task
{
    public class LittleRedRidingHood : Tale
    {
        // Дополнительные свойства
        public string GrandmaName { get; set; }
        public bool HasWolf { get; set; }

        public double RatingScore { get; set; }

        public string OriginalLanguage { get; set; }


        // Конструкторы
        public LittleRedRidingHood(string author, int yearPublished)
            : base("Little Red Riding Hood", author, yearPublished, "Little Red Riding Hood")
        {
            GrandmaName = "Grandma";
            HasWolf = true;
            RatingScore = 7.7;
            OriginalLanguage = "French";
        }

        public LittleRedRidingHood(string author, int yearPublished, string grandmaName, bool hasWolf,string originalLanguage, double ratingScore)
            : base("Little Red Riding Hood", author, yearPublished, "Little Red Riding Hood")
        {
            GrandmaName = grandmaName;
            HasWolf = hasWolf;
            RatingScore=ratingScore;
            OriginalLanguage = originalLanguage;
        }

        // Методы
        public override void Name()
        {
            Console.WriteLine("\nLittle red Riding hood");

        }
        public override void Link()
        {
            Console.Write("\nLink: ");
            Console.WriteLine("https://www.grimmstories.com/language.php?grimm=026&l=en&r=ru\n");
        }
       

        public override void Plot()
        {
            Console.WriteLine("\nIntroduction: In a village in the woods...");
            Console.WriteLine("\nPlot: A little girl named Little Red Riding Hood went to visit her grandmother...");
            Console.WriteLine("\nEnding: Little Red Riding Hood returned home happily and safely.\n");
        }

        public override void MoralLesson()
        {
            Console.WriteLine("\nMoral lesson: Don't talk to strangers and always listen to your parents.\n");
        }
        
        public override void ShortInfo()
        {
            Console.WriteLine("\nShort version of 'Little Red Riding Hood':");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year Published:  {YearPublished}");
            Console.WriteLine($"Main Character: {MainCharacter}\n");
        }
        public override void ExtendedInfo()
        {
            Console.WriteLine("\nExtended version of 'Little Red Riding Hood':");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year Published: {YearPublished}");
            Console.WriteLine($"Main Character: {MainCharacter}");
            Console.WriteLine($"Grandma name: {GrandmaName}");
            Console.WriteLine($"Has wolf: {HasWolf}");
            Console.WriteLine($"Original languages: {OriginalLanguage}");
            Console.WriteLine($"Rating score: {RatingScore}/10\n");
        }
        public override void Description()
        {
            Console.WriteLine("\"Little Red Riding Hood\" is a European fairy tale about a young girl and a sly wolf.Its origins can be traced back to several pre-17th century European folk tales. The two best known versions were written by Charles Perrault and the Brothers Grimm.\r\n\r\nThe story has been changed considerably in various retellings and subjected to numerous modern adaptations and readings. Other names for the story are \"Little Red Cap\" or simply \"Red Riding Hood\". It is number 333 in the Aarne–Thompson classification system for folktales.\n");
        }
    }
}
