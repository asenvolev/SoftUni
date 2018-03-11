using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineRadioDatabase.Exceptions;

namespace OnlineRadioDatabase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numOfCommands = int.Parse(Console.ReadLine());
            var playlist = new List<Song>();
            for (int i = 0; i < numOfCommands; i++)
            {
                var input = Console.ReadLine().Split(';').ToArray();
                string artist = input[0];
                string name = input[1];
                var songLenght = input[2].Split(':').ToArray();
                int minutes;
                int seconds;
                try
                { 
                    if (int.TryParse(songLenght[0], out minutes) && int.TryParse(songLenght[1], out seconds))
                    {
                        playlist.Add(new Song(artist, name, minutes, seconds));
                        Console.WriteLine("Song added.");
                    }
                    else
                    {
                        throw new InvalidSongLengthException();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            int secondsTotal = 0;
            int minutesTotal = 0;
            int hoursTotal = 0;
            foreach (Song song in playlist)
            {
                secondsTotal += song.Seconds;
                minutesTotal += song.Minutes;
            }
            minutesTotal += secondsTotal / 60;
            secondsTotal %= 60;
            hoursTotal = minutesTotal / 60;
            minutesTotal %= 60;
            Console.WriteLine($"Songs added: {playlist.Count}");
            Console.WriteLine($"Playlist length: {hoursTotal}h {minutesTotal}m {secondsTotal}s"); 
        }
    }
}
