using DemoNetcore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DemoNetcore.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movie { get; set; }
        public List<Student> Students { get; set; }
        public SelectList ds { get; set; }
        public string loaidachon { get; set; }
        public string SearchString { get; set; }
    }
}