using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesDemo
{
    internal class Movie
    {
        //Instance Fields
        private string _name;
        private string _description;
        private string _year;

        //Constructor
        public Movie() { }

        public Movie(string name, string description, string year)
        {
            _name = name;
            _description = description;
            _year = year;
        }

        //Properties
        public string Name
        {
            get { return _name; }   
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Year
        {
            get { return _year; }
            set { _year = value; }
        }

        //ToString()
        //Getter for multiple pieces of data
        public override string ToString()
        {
            return $"{_name} was made in {_year} and has a description of {_description}";
        }


    }
}
