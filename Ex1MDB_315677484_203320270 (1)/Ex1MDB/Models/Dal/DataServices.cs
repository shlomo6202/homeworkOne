using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ex1MDB.Models.Dal
{
    public class DataServices
    {
        static List<Movie> moviesList = new List<Movie>();


        public int InsertMovie(Movie movie)
        {
            if(moviesList == null) {
                moviesList = new List<Movie>();
            }

            moviesList.Add(movie);

            return moviesList.Count;
        }
    }
}