using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9_1
{
    internal class OurForm:Form
    {
        //Создание элемента управления RichTextBox для вывода информации об объекте
        RichTextBox _objectInfoRichTextBox = new RichTextBox();
        //Создание элемента управления ComboBox для реализации выпадающего списка фильмов
        ComboBox _filmsListComboBox = new ComboBox();
        //Список объектов класса "Film"
        List<Film> _filmsList = new List<Film>() 
        {
            new Film(1, "Любовь и голуби", "1984", "СССР", "мелодрама, комедия", 107, -1 ),
            new Film(2, "Иван Васильевич меняет профессию", "1973", "СССР", "комедия, фантастика, приключения", 88, -1),

        };
        //Конструктор класса без параметров
        public OurForm()
        {
            //Установление ширины формы
            this.Width = 600;
            //Установление высоты формы
            this.Height = 400;
            //Установление стартового расположения формы
            this.StartPosition = FormStartPosition.CenterScreen;

            //Установление левого отступа для RichTextBox
            this._objectInfoRichTextBox.Left = 10;
            //Установление верхнего отступа для RichTextBox
            this._objectInfoRichTextBox.Top = 40;
            //Установление ширины RichTextBox
            this._objectInfoRichTextBox.Width = 400;
            //Установление высоты RichTextBox
            this._objectInfoRichTextBox.Height = 350;
            //Обозначить RichTextBox доступным только для чтения
            this._objectInfoRichTextBox.ReadOnly = true;

            //Установление левого отступа для ComboBox
            this._filmsListComboBox.Left = 10;
            //Установление верхнего отступа для ComboBox
            this._filmsListComboBox.Top = 10;
            //Установление ширины ComboBox
            this._filmsListComboBox.Width = 300;
            //Добавление элементов из списка в ComboBox
            foreach(var film in _filmsList)
            {
                this._filmsListComboBox.Items.Add(film);
            }
            //Подписываемся на событие изменения выбранного значения
            this._filmsListComboBox.SelectedValueChanged += _filmsListComboBox_SelectedValueChanged;

            //Добавляем созданные элементы на форму
            this.Controls.Add(this._objectInfoRichTextBox);
            this.Controls.Add(this._filmsListComboBox);
        }

        //Обработчик события
        void _filmsListComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //Вывод информации о выбранном объекте в элемент RichTextBox
            _objectInfoRichTextBox.Text = _filmsList[this._filmsListComboBox.SelectedIndex].PrintInfo();
        }
    }
}
