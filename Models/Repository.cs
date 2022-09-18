using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movieApp.Models
{
    public class Repository
    {
        private static List<Movie> _movies = null;

        static Repository(){
            _movies = new List<Movie>(){
                new Movie() {Id=1,Name="",Description="",ImageUrl=""}
            };
        }
        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity){
            _movies.Add(entity);
        }

        public static Movie GetById(int id){
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}