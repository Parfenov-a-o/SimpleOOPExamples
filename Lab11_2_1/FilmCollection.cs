using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_2_1
{
    internal class FilmCollection : IEnumerable
    {
        Film[] films;

        public FilmCollection()
        {
            films = new Film[] 
            { 
                new Film(1, "Джентльмены удачи", "1971", "СССР", "комедия, драма, криминал, детектив", 84, 10560943), 
                new Film(2, "Служебный роман", "1977", "СССР", "мелодрама, комедия, драма", 159, -1), 
                new Film(3, "Офицеры", "1971", "СССР", "драма, военный, мелодрама", 91, -1) 
            };
        }

        public Film this[int k]
        {
            get { return films[k]; }
            set { films[k] = value; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return films.GetEnumerator();
        }

        public int Kolvo
        {
            get { return films.Length; }
        }
    }
}
