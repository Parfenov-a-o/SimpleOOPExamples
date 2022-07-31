namespace Lab9_2
{
    public partial class Form1 : Form
    {

        //Список объектов класса "Film"
        List<Film> _filmsList = new List<Film>()
        {
            new Film(1, "Любовь и голуби", "1984", "СССР", "мелодрама, комедия", 107, -1 ),
            new Film(2, "Иван Васильевич меняет профессию", "1973", "СССР", "комедия, фантастика, приключения", 88, -1),

        };
        public Form1()
        {
            InitializeComponent();

            //Добавить список фильмов в выпадающий список 
            this.filmsListComboBox.Items.AddRange(_filmsList.ToArray());
        }

        //Обработчик события при изменении выбранного в выпадающем списке фильма
        private void filmsListComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //Вывести сведения о выбранном фильме в соответствующие TextBox
            this.idTextBox.Text = _filmsList[filmsListComboBox.SelectedIndex].Id.ToString();
            this.nameTextBox.Text = _filmsList[filmsListComboBox.SelectedIndex].Name;
            this.yearTextBox.Text = _filmsList[filmsListComboBox.SelectedIndex].Year.ToString();
            this.countryTextBox.Text = _filmsList[filmsListComboBox.SelectedIndex].Country;
            this.genreTextBox.Text = _filmsList[filmsListComboBox.SelectedIndex].Genre;
            this.durationTextBox.Text = _filmsList[filmsListComboBox.SelectedIndex].Duration.ToString();
            this.feesTextBox.Text = _filmsList[filmsListComboBox.SelectedIndex].FeesInTheWorld.ToString();

            //Вывести информацию об объекте в RichTextBox
            this.richTextBox1.Text = _filmsList[filmsListComboBox.SelectedIndex].PrintInfo();
        }

        //Обработчик события для кнопки
        private void editButton_Click(object sender, EventArgs e)
        {
            //Проверка на корректность преобразования введенного в текстовое поле значения в тип "int"
            if (Int32.TryParse(this.feesTextBox.Text, out int value))
            {
                //Изменение свойства "FeesInTheWorld" фильма в соответствии с введенным значением
                _filmsList[filmsListComboBox.SelectedIndex].FeesInTheWorld = value;
                MessageBox.Show("Изменения внесены успешно!");
                this.richTextBox1.Text = _filmsList[filmsListComboBox.SelectedIndex].PrintInfo();
            }
            else
            {
                MessageBox.Show("Вы ввели некорректные данные!");
                this.feesTextBox.Text = _filmsList[filmsListComboBox.SelectedIndex].FeesInTheWorld.ToString();
            }
            
        }
    }
}