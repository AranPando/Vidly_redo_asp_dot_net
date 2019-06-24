using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyRedo.Models;
using VidlyRedo.Managers;
using VidlyRedo.ViewModels;

namespace VidlyRedo.Models
{
    public static class GlobalVariables
    {
        public static CustomerManager CustManager = new CustomerManager();
        public static MovieManager MovManager = new MovieManager();

        //******* Customer Manager Methods ********\\
   
        public static List<Customer> GetCustomers()
        {
            return CustManager.GetCustomers();
        }

        public static Customer AddCustomer(int id, string name)
        {
            return CustManager.AddCustomer(id, name);
        }

        public static Customer GetCustomerId(int id)
        {
            return CustManager.GetCustomerId(id);
        }

        //******* Movie Manager Methods ********\\

        public static List<Movie> GetMovies()
        {
            return MovManager.GetMovies();
        }

        public static Movie AddMovie(int id, string name, string year)
        {
            return MovManager.AddMovie(id, name, year);
        }

        public static Movie GetMovieName(string name)
        {
            return MovManager.GetMovieName(name);
        }

    }
}