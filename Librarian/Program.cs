
using Librarian;
using static System.Formats.Asn1.AsnWriter;

Librari lib = new Librari();
//Books book = new Books();


string? cmd = "";
string? ans = "";
string bname, bauthor, bgenre, bpubl;
int bid, bcount, byear;

while (true)
{

    cmd = Console.ReadLine();

    if (cmd == "-help")
    {
        Console.WriteLine("Все возможные команды для этой программы: \n" +
            "-input  --  Добавить новую книгу/журнал \n" + "-delete  --  Удаление книги/журнала по ID \n" +
              "-change  --  Изменить данные о книге/журнале \n" + "-search  --  Поиск книги/журнала по названию \n" +
              "-end  --  Выход");
    }
    if (cmd == "-input")
    {
        Console.WriteLine("Вы желаете добавить книгу или журнал?");
        ans = Console.ReadLine();

        if (ans == "Книгу" || ans == "книгу")
        {
            Console.WriteLine("Введите ID книги:");
            bid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите Название книги:");
            bname = Console.ReadLine();

            Console.WriteLine("Введите количество книг:");
            bcount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите автора книги:");
            bauthor = Console.ReadLine();

            Console.WriteLine("Введите жанр книги:");
            bgenre = Console.ReadLine();

            Console.WriteLine("Введите год издания книги:");
            byear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите издательство книги:");
            bpubl = Console.ReadLine();

            newItem(bid, bname, " ", bcount, bauthor, bgenre, byear, bpubl, 0);

        }
    }
    if(cmd == "-end")
    {
        break;
    }
    if(cmd == "-delete")
    {
        Console.WriteLine("Вы желаете удалить книгу или журнал?");
        ans = Console.ReadLine();

        if (ans == "Книгу" || ans == "книгу")
        {
            Console.WriteLine("Введите ID книги:");
            bid = Convert.ToInt32(Console.ReadLine());
            deleteItem(bid, 0);
        }
    }
    if(cmd == "-change")
    {
        Console.WriteLine("Вы желаете изменить книгу или журнал?");
        ans = Console.ReadLine();

        if (ans == "Книгу" || ans == "книгу")
        {
            Console.WriteLine("Введите ID книги:");
            bid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваша книга называется: <" + lib.bname(bid) + ">?");

        }
    }



    void newItem(int new_id, string new_name, string new_freq, int new_count, string new_author, string new_genre, int new_year, string new_publisher, int number)
    {

        if (Convert.ToInt32(number) == 0)
        {
            Books newbook = new Books(new_id, new_name, new_count, new_author, new_genre, new_year, new_publisher);
            lib.add_book(newbook);
        }
        else
        {
            Journal newjournal = new Journal(new_id, new_name, new_freq, new_count, new_year, new_publisher , number);
            lib.add_journal(newjournal);

        }
    }

    void deleteItem(int id, int chk) 
    {
        if (Convert.ToInt32(chk) == 0)
        { 
          lib.delete_book(id);
        }
        else
        {
          lib.delete_journal(id);

        }
    }

}