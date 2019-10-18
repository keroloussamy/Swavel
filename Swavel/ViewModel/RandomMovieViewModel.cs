using Swavel.Models;
using System.Collections.Generic;

namespace Swavel.ViewModel
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}