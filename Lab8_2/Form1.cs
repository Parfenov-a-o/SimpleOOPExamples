namespace Lab8_2
{
    public partial class Form1 : Form
    {
        Film<string, string, GenresEnum> film3 = new Film<string, string, GenresEnum>(1, "Один дома", "1990", "США",
                                                        GenresEnum.Comedy, 103, 476684675);

        public Form1()
        {
            InitializeComponent();

            Actor<string> _actor7 = new Actor<string>(1, "Маколей", "Калкин", "1980.08.26");
            Actor<string> _actor8 = new Actor<string>(2, "Джо", "Пеши", "1943.02.09");
            Actor<string> _actor9 = new Actor<string>(3, "Дэниел", "Стерн", "1957.08.28");

            film3.Actors.Add(_actor7);
            film3.Actors.Add(_actor8);
            film3.Actors.Add(_actor9);

            this.richTextBox1.Text = film3.ToString();

        }

        private void AddActorButton_Click(object sender, EventArgs e)
        {
            if((this.nameTextBox.Text != "") && (this.surnameTextBox.Text != ""))
            {
                Actor<string> _actor = new Actor<string>(film3.Actors.Count+1, this.nameTextBox.Text, this.surnameTextBox.Text, this.BirthDateTimePicker.Value.Date.ToString("yyyy.MM.dd"));
                film3.Actors.Add(_actor);
                this.richTextBox1.Text = film3.ToString();
                MessageBox.Show("Актёр успешно добавлен!");
            }
            else
            {
                MessageBox.Show("Вы не заполнили все необходимые поля!");
            }
            
        }
    }
}