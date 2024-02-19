using System;
namespace music
{
    class Program
    {
        enum Genre
        {
            Country,
            Metal,
            Orchestral,
            Swing,
            Rap
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private int Length;
            private Genre? Genre;

            public void setTitle(string title)
            {
                Title = title;
            }

            public void setArtist(string artist)
            {
                Artist = artist;
            }

            public void setAlbum(string album)
            {
                Album = album;
            }

            public void setLength(int length)
            {
                Length = length;
            }

            public void setGenre(Genre? genre)
            {
                Genre = genre;
            }

            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many songs would you like to enter?");
            int size = int.Parse(Console.ReadLine());
            Music[] collection = new Music[size];

            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("What is the name of the song?");
                    collection[i].setTitle(Console.ReadLine());

                    Console.WriteLine("Who is the artist?");
                    collection[i].setArtist(Console.ReadLine());

                    Console.WriteLine("What is the name of the Album?");
                    collection[i].setAlbum(Console.ReadLine());

                    Console.WriteLine("How long is the song?");
                    collection[i].setLength(int.Parse(Console.ReadLine()));

                    Console.WriteLine("What is the genre?");
                    Console.WriteLine("C - Country\nM - Metal\nO - Orchestal\nS - Swing\nR - Rap");
                    Genre tempMusic = Genre.Country;
                    string t = Console.ReadLine();
                    switch (t)
                    {
                        case "C":
                            tempMusic = Genre.Country;
                            break;
                        case "M":
                            tempMusic = Genre.Metal;
                            break;
                        case "O":
                            tempMusic = Genre.Orchestral;
                            break;
                        case "S":
                            tempMusic = Genre.Swing;
                            break;
                        case "R":
                            tempMusic = Genre.Rap;
                            break;
                    }
                    collection[i].setGenre(tempMusic);
       
            }
            } 
            catch (ArgumentException e) 
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e) 
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for(int i = 0; i < size; i++)
                {
                    Console.WriteLine($"{collection[i].Display()}");
                }
            }
        }
    }
}