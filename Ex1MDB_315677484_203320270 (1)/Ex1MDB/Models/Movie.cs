using Ex1MDB.Models.Dal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ex1MDB.Models
{
    public class Movie
    {
        int id;
        String name;
        String description;
        ArrayList genre;
        DateTime releaseDate;
        String url;
        double score;

        public Movie(int id, string name, string description, ArrayList genre, DateTime releaseDate, string url, double score)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Genre = genre;
            this.ReleaseDate = releaseDate;
            this.Url = url;
            this.Score = score;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public ArrayList Genre { get => genre; set => genre = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public string Url { get => url; set => url = value; }
        public double Score { get => score; set => score = value; }

        public int InsertMovie()
        {
            DataServices ds = new DataServices();
            return ds.InsertMovie(this);
        }
    }
} 