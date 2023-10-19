using System;
using Task;

namespace Task
{
    public class Cinderella : Tale
    {
        // Дополнительные свойства
        
        public string PrinceName { get; set; }
        public bool HasHappyEnding { get; set; }
        public double RatingScore { get; set; }
        public string OriginalLanguage { get; set; }

        // Конструкторы
        public Cinderella(string author, int yearPublished)
            : base("Cinderella", author, yearPublished, "Cinderella")
        {
            PrinceName = "Prince Charming";
            HasHappyEnding = true;
            RatingScore = 8.3;
            OriginalLanguage = "French, english , greek";
        }

        public Cinderella(string author, int yearPublished, string princeName, bool hasHappyEnding,string originalLanguage , double ratingScore)
            : base("Cinderella", author, yearPublished, "Cinderella")
        {
            PrinceName = princeName;
            HasHappyEnding = hasHappyEnding;
            RatingScore = ratingScore;
            OriginalLanguage = originalLanguage;
        }

        // Методы
        public override void Name()
        {
            Console.WriteLine("\nCinderella");
           
        }
        public override void Link()
        {
            Console.Write("\nLink: ");
            Console.WriteLine("https://madbook.org/view?book=155&page=1\n");
        }
       
        public override void Plot()
        {
            Console.WriteLine("\nIntroduction: Once upon a time...");
            Console.WriteLine("\nPlot: There was a girl named Cinderella...");
            Console.WriteLine("\nEnding: And a few days after, they married...\n");
        }

        public override void MoralLesson()
        {
            Console.WriteLine("\nMoral Lesson: Be kind and patient, and good things will happen.\n");
        }
       
        public override void ShortInfo()
        {
            Console.WriteLine("\nShort version of 'Cinderella':");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year Published:  {YearPublished}");
            Console.WriteLine($"Main Character: {MainCharacter}\n");
        }
        public override void ExtendedInfo()
        {
            Console.WriteLine("\nExtended version of 'Cinderella':");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year Published: {YearPublished}");
            Console.WriteLine($"Main Character: {MainCharacter}");
            Console.WriteLine($"Prince Name: {PrinceName}");
            Console.WriteLine($"Has Happy Ending: {HasHappyEnding}");
            Console.WriteLine($"Original languages: {OriginalLanguage}");
            Console.WriteLine($"Rating score: {RatingScore}/10\n");
        }
        public override void Description()
        {
            Console.WriteLine("\"Cinderella\", or \"The Little Glass Slipper\",\nis a folk tale with thousands of variants that is told throughout the world. \nThe protagonist is a young girl living in forsaken circumstances that are suddenly changed to remarkable fortune, \nwith her ascension to the throne via marriage. The story of Rhodopis, \nrecounted by the Greek geographer Strabo sometime between 7 BC and AD 23, about a Greek slave girl who marries the king of Egypt, is usually considered to be the earliest known variant of the Cinderella story.\n\nThe first literary European version of the story was published in Italy by Giambattista Basile in his Pentamerone in \n1634;the version that is now most widely known in the English-speaking world was published in French by Charles Perrault in Histoires ou contes du temps passé in 1697.Another version was later published as Aschenputtel by the Brothers Grimm in their folk tale collection Grimms Fairy Tales in 1812.\r\n\r\nAlthough the story's title and main character's name change in different languages, in English-language folklore Cinderella is an archetypal name. The word Cinderella has, by analogy, come to mean someone whose attributes are unrecognized, or someone unexpectedly achieves recognition or success after a period of obscurity and neglect. In the world of sports, \"a Cinderella\" is used for an underrated team or club winning over stronger and more favored competitors. The still-popular story of Cinderella continues to influence popular culture internationally, lending plot elements, allusions, and tropes to a wide variety of media.\n");
        }

    }
}
