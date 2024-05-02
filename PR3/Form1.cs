using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3
{
    public partial class Scrabble : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        private Dictionary<string, Dictionary<char, int>> languages = new Dictionary<string, Dictionary<char, int>>
        {
                {"Английский", new Dictionary<char, int>
                {
                    {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N', 1}, {'S', 1}, {'T', 1}, {'R', 1},
                    {'D', 2}, {'G', 2},
                    {'B', 3}, {'C', 3}, {'M', 3}, {'P', 3},
                    {'F', 4}, {'H', 4}, {'V', 4}, {'W', 4}, {'Y', 4},
                    {'K', 5},
                    {'J', 8}, {'X', 8},
                    {'Q', 10}, {'Z', 10}
                }
            },
            {"Русский", new Dictionary<char, int>
                {
                    {'А', 1}, {'В', 1}, {'Е', 1}, {'И', 1}, {'Н', 1}, {'О', 1}, {'Р', 1}, {'С', 1}, {'Т', 1},
                    {'Д', 2}, {'К', 2}, {'Л', 2}, {'М', 2}, {'П', 2}, {'У', 2},
                    {'Б', 3}, {'Г', 3}, {'Ё', 3}, {'Ь', 3}, {'Я', 3},
                    {'Й', 4}, {'Ы', 4},
                    {'Ж', 5}, {'З', 5}, {'Х', 5}, {'Ц', 5}, {'Ч', 5},
                    {'Ш', 8}, {'Э', 8}, {'Ю', 8},
                    {'Ф', 10}, {'Щ', 10}, {'Ъ', 10}
                }
            }
        };


        private string selectedLanguage = null;
        public Scrabble()
        {
            InitializeComponent();
        }
        private bool WordHaveNumber(string input)
        {


            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;

        }
        private int CalculateScore(string word, Dictionary<char, int> lettersValues)
        {
            int score = 0;
            foreach (char letter in word)
            {
                if (lettersValues.ContainsKey(letter))
                {
                    score += lettersValues[letter];
                }
            }
            return score;
        }
        public async void Calculate()
        {
            try
            {
                string inputString = input_Data1.Text;
                if (WordHaveNumber(inputString))
                {
                    errorProvider.SetError(input_Data1, "Строка содержит цифры!");
                    await Task.Delay(2000);
                    errorProvider.SetError(input_Data1, "");
                }
                else
                if (string.IsNullOrEmpty(input_Data1.Text))
                {
                    errorProvider.SetError(input_Data1, "Поле не должно быть пустым!");
                    await Task.Delay(2000);
                    errorProvider.SetError(input_Data1, "");
                }
                else
                {
                    string word = input_Data1.Text.ToUpper();
                    int score = CalculateScore(word, languages[selectedLanguage]);
                    result_1.Text = $"{score}";
                }
            }
            catch (ArgumentNullException)
            {
                errorProvider.SetError(input_Data1, "Выберите язык!");
                await Task.Delay(2000);
                errorProvider.SetError(input_Data1, "");
            }
        }
        private void close_1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void close_2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            result_1.Clear();
            input_Data1.Clear();
        }

        private void calculation_button_2_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void button_English_Select_Click(object sender, EventArgs e)
        {
            selectedLanguage = "Английский";
            MessageBox.Show("Выбран английский язык.");
        }

        private void button_Russian_Select_Click(object sender, EventArgs e)
        {
            selectedLanguage = "Русский";
            MessageBox.Show("Выбран русский язык.");
        }

        private void aboutTheProgram_Click(object sender, EventArgs e)
        {
            AboutTheProgram newF = new AboutTheProgram();
            newF.Show();
        }

        private void calculation_button_1_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void input_Data1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
