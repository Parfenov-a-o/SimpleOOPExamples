using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_1_1
{
    internal class КоллекцияКниг:IEnumerable
    {
        Книга[] книги;

        public КоллекцияКниг()
        {
            книги = new Книга[] { new Книга("Сказки"), new Книга("Байки"), new Книга("Анекдоты") };
        }

        public Книга this[int k]
        {
            get { return книги[k]; }
            set { книги[k] = value; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return книги.GetEnumerator();
        }

        public int Количество
        {
            get { return книги.Length; }
        }
    }
}
