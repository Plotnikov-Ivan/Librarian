using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian
{
    internal class Librari
    {

        LinkedList<Books> books = new LinkedList<Books>();
        LinkedList<Journal> journals = new LinkedList<Journal>();   


        public void add_book(Books book)
        {
            books.AddLast(book);
        }

        public void add_journal(Journal jr)
        {
            journals.AddLast(jr);
        }

        public void delete_book(int id)
        {
            foreach (Books b in books)
            {
                if (b.get_id() == id)
                {
                    books.Remove(b);
                    break;
                }
            }

        }

        public void delete_journal(int id)
        {
            foreach (Journal jr in journals)
            {
                if (jr.get_id() == id)
                {
                    journals.Remove(jr);
                    break;
                }
            }

        }

        public string bname( int id)
        {
            foreach (Books b in books)
            {
                if (b.get_id() == id)
                {
                    return b.get_name();                   
                }
            }
            return " ";
        }


    }
}
