using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movieApp.Models;

namespace movieApp.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories = null;

        static CategoryRepository(){
            _categories = new List<Category>(){
                new Category() {Id=1,Name="Adventure"},
                new Category() {Id=2,Name="Romance"},
                new Category() {Id=3,Name="Science"},
                new Category() {Id=4,Name="War"},
                new Category() {Id=5,Name="Comedy"}
            };
        }
        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

        public static void AddMCategory(Category entity){
            _categories.Add(entity);
        }

        public static Category GetById(int id){
            return _categories.FirstOrDefault(i => i.Id == id);
        }
    }
}