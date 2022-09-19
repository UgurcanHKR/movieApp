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
                new Movie() {Id=1,Name="A",Description="X",ImageUrl="1.jpg"},
                new Movie() {Id=2,Name="B",Description="Y",ImageUrl="2.jpg"},
                new Movie() {Id=3,Name="C",Description="Z",ImageUrl="3.jpg"},
                new Movie() {Id=4,Name="D",Description="T",ImageUrl="4.jpg"},
                new Movie() {Id=5,Name="E",Description="U",ImageUrl="5.jpg"}
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