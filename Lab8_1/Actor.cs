using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_1
{
    //Обобщенный класс, который принимает один параметр типа
    internal class Actor<T>
    {
        //Код актёра
        int _id;
        //Имя актёра
        string _name;
        //Фамилия актёра
        string _surname;
        //Дата рождения
        T _birthDate;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public T BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
        //Параметрический конструктор
        public Actor(int i, string n, string s, T bd)
        {
            _id = i;
            _name = n;
            _surname = s;
            _birthDate = bd;
        }
        //Переопределенный метод ToString()
        public override string ToString()
        {
            return $"{_name} {_surname} Дата рождения: {BirthDate}";
        }

    }
}
