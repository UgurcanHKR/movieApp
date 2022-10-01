using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movieApp.Models;

namespace movieApp.Data
{
    public class ProductRepository
    {
        private static List<Movie> _movies = null;

        static ProductRepository(){
            _movies = new List<Movie>(){
                new Movie() {Id=1,Name="The Bridge",ShortDescription="The Bridge",Description="<p>When a body is found on the bridge between Denmark and Sweden, right on the border, Danish inspector Martin Rohde and Swedish Saga Norén have to share jurisdiction and work together to find the killer.</p>",ImageUrl="1.jpg"},
                new Movie() {Id=2,Name="North Sea Connection",ShortDescription="North Sea Connection",Description="<p>The stunning scenery of Ireland's west coast conceals a dark secret in 'North Sea Connection', in which Ciara must confront the dramatic consequences of her brother Aidan's decision to transport drugs at sea.</p>",ImageUrl="2.jpg"},
                new Movie() {Id=3,Name="The Square",ShortDescription="The Square",Description="<p>A prestigious Stockholm museum's chief art curator finds himself in times of both professional and personal crisis as he attempts to set up a controversial new exhibit.</p>",ImageUrl="3.jpg"},
                new Movie() {Id=4,Name="Border",ShortDescription="Border",Description="<p>A customs officer who can smell fear develops an unusual attraction to a strange traveler while aiding a police investigation which will call into question her entire existence.</p>",ImageUrl="4.jpg"},
                new Movie() {Id=5,Name="Love & Anarchy",ShortDescription="Love & Anarchy",Description="<p>When Sofie, a career-driven consultant and married mother of two, gets an assignment to modernize an old publishing house, she meets young IT tech Max and an unexpected flirting game begins.</p>",ImageUrl="5.jpg"}
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