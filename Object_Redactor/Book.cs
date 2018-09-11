using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Redactor
{
    class Book
    {
        string _name;
        string _author;
        int _page_number;
        bool _binding;

        public Book()
        {
            _name = "default";
            _author = "default";
            _page_number = 0;
            _binding = true;
        }

        public Book(string name, string author, int page_number, bool binding)
        {
            _name = name;
            _author = author;
            _page_number = page_number;
            _binding = binding;
        }

        override public string ToString()
        {
            string tmp = String.Concat(_name);
            return tmp;
        }
 
        public string getAuthor()
        {
            return _author;
        }

        public int getNumberPages()
        {
            return _page_number;
        }

        public bool getBinding()
        {
            return _binding;
        }

    }
}
