﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineRadioDatabase.Exceptions;

namespace OnlineRadioDatabase
{
    public class Song
    {
        private string artist;
        private string name;
        private int minutes;
        private int seconds;
        public Song(string artist, string name, int minutes, int seconds)
        {
            this.Artist = artist;
            this.Name = name;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
        public string Artist
        {
            get
            {
                return this.artist;
            }

            set
            {
                if (value.Length<3 || value.Length>20)
                {
                    throw new InvalidArtistNameException();
                }
                this.artist = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
                
            }

            set
            {
                if (value.Length<3 || value.Length>30)
                {
                    throw new InvalidSongNameException();
                }
                this.name = value;
            }
        }

        public int Minutes
        {
            get
            {
                return this.minutes;
            }

            set
            {
                if (value<0||value>14)
                {
                    throw new InvalidSongMinutesException();
                }
                this.minutes = value;
            }
        }

        public int Seconds
        {
            get
            {
                return this.seconds;
            }

            set
            {
                if (value<0 || value>59)
                {
                    throw new InvalidSongSecondsException();
                }
                this.seconds = value;
            }
        }
    }
}