namespace Homework_26._10._23
{
    class Song
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public Song Next { get; set; }

        public Song(string name, string author)
        {
            Name = name;
            Author = author;
            Next = null;
        }

        public string Title()
        {
            return $"{Name} , автор: {Author}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Song otherSong)
            {
                return this.Name == otherSong.Name && this.Author == otherSong.Author;
            }
            return false;
        }
    }

}
