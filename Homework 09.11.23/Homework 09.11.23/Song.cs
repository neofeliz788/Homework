namespace Homework_9._11._23
{
    class Song
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public Song Next { get; set; }

        public Song(string name, string author, Song next = null)
        {
            Name = name;
            Author = author;
            Next = next;
        }
        public Song(Song next = null)
        {
            Next = next;
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
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

}
