namespace Lab9_2
{
    public partial class Form1 : Form
    {

        //������ �������� ������ "Film"
        List<Film> _filmsList = new List<Film>()
        {
            new Film(1, "������ � ������", "1984", "����", "���������, �������", 107, -1 ),
            new Film(2, "���� ���������� ������ ���������", "1973", "����", "�������, ����������, �����������", 88, -1),

        };
        public Form1()
        {
            InitializeComponent();

            //�������� ������ ������� � ���������� ������ 
            this.filmsListComboBox.Items.AddRange(_filmsList.ToArray());
        }

        //���������� ������� ��� ��������� ���������� � ���������� ������ ������
        private void filmsListComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //������� �������� � ��������� ������ � ��������������� TextBox
            this.idTextBox.Text = _filmsList[filmsListComboBox.SelectedIndex].Id.ToString();
            this.nameTextBox.Text = _filmsList[filmsListComboBox.SelectedIndex].Name;
            this.yearTextBox.Text = _filmsList[filmsListComboBox.SelectedIndex].Year.ToString();
            this.countryTextBox.Text = _filmsList[filmsListComboBox.SelectedIndex].Country;
            this.genreTextBox.Text = _filmsList[filmsListComboBox.SelectedIndex].Genre;
            this.durationTextBox.Text = _filmsList[filmsListComboBox.SelectedIndex].Duration.ToString();
            this.feesTextBox.Text = _filmsList[filmsListComboBox.SelectedIndex].FeesInTheWorld.ToString();

            //������� ���������� �� ������� � RichTextBox
            this.richTextBox1.Text = _filmsList[filmsListComboBox.SelectedIndex].PrintInfo();
        }

        //���������� ������� ��� ������
        private void editButton_Click(object sender, EventArgs e)
        {
            //�������� �� ������������ �������������� ���������� � ��������� ���� �������� � ��� "int"
            if (Int32.TryParse(this.feesTextBox.Text, out int value))
            {
                //��������� �������� "FeesInTheWorld" ������ � ������������ � ��������� ���������
                _filmsList[filmsListComboBox.SelectedIndex].FeesInTheWorld = value;
                MessageBox.Show("��������� ������� �������!");
                this.richTextBox1.Text = _filmsList[filmsListComboBox.SelectedIndex].PrintInfo();
            }
            else
            {
                MessageBox.Show("�� ����� ������������ ������!");
                this.feesTextBox.Text = _filmsList[filmsListComboBox.SelectedIndex].FeesInTheWorld.ToString();
            }
            
        }
    }
}