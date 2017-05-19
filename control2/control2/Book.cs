using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control2
{
  public  class Book
    {
        public string Name;
        public int Year;
        public int AuthorID;

        public override string ToString()
        {
            return $"Name -{Name}, year:{Year} ";
        }
    }

    public class Author
    {
        public string Name;
        public int AuthorID;
    }
}
