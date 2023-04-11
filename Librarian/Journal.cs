using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian
{
    internal class Journal
    {

        private int id = 0;

        private string name = "";

        private string freq = "";

        private int count = 0;

        private int year = 0;

        private string publisher = "";

        private int number = 0;


        public Journal(int new_id, string new_name, string new_freq, int new_count, int new_year, string new_publisher, int new_number)
        {
            id = new_id;
            year = new_year;
            count= new_count;
            name = new_name;
            freq = new_freq;
            number= new_number;
            publisher = new_publisher;
        }


        public int get_id()
        {
            return id;
        }
    }
}
