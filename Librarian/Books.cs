using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Librarian
{
    internal class Books
    {
        private int id = 0;

        private string name = "";

        private int count = 0;

        private string author = "";

        private string genre = "";
        
        private int year = 0;

        private string publisher = "";


        public Books(int new_id, string new_name, int new_count, string new_author, string new_genre, int new_year, string new_publisher)
        {
            id = new_id;
            year = new_year;
            name = new_name;
            count = new_count;
            author = new_author;
            genre = new_genre;
            publisher = new_publisher;
        }


        public int get_id()
        {
            return id;
        }

        public string get_name() 
        { return name; }
    }
}
