using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    internal class Actor
    {
        int _id;
        string _name;
        string _surname;
        DateOnly _birthDate;

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
        public DateOnly BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public string TextForWritting
        {
            get
            {
                return $"{_id};{_name};{_surname};{_birthDate}";
            }
        }

        public Actor(int i, string n, string s, DateOnly bd)
        {
            _id = i;
            _name = n;
            _surname = s;
            _birthDate = bd;
        }
        public Actor(string str)
        {
            string [] s = str.Split(';');

            try { _id = int.Parse(s[0]); } catch { _id = 0; }
            try { _name = s[1]; } catch { _name = "Неизвестный актер"; }
            try { _surname = s[2]; } catch { _surname = ""; }
            try { _birthDate = DateOnly.Parse(s[3]); } catch { _birthDate = new DateOnly(1990,1,1) ; }
        }

        public override string ToString()
        {
            return $"{_name} {_surname}";
        }

    }
}
