using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int N = 4, M = 10; //размер массива
        int[] numbers = new int[4]; //массив для задания 1
        int[,] fdnumbers = new int[4, 10];//для задания 2
        int[,] matrix = new int[4, 10]; //для задания 3
        int Task;// номер задания

        /* Задание 1 */
        private int ClosestToAverage()
        {
            int sum = 0, sr, k = 0, mindist = 100;
            for(int i = 0; i < N; i++)
            {
                sum += numbers[i];//cумма элементов массива
            }
            sr = sum / N; // среднее значение
            for (int i = 0; i < N; i++)
            {
                if(mindist > Math.Abs(numbers[i] - sr))//находим ближайшее к среднему
                {
                    mindist = Math.Abs(numbers[i] - sr);
                    k = i;
                }
            }
            return numbers[k];
        }

        /* Задание 2 */
        private int MinFreedigitNumber()
        {
            int min = 1000;
            bool check = false;
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < M; j++)
                {
                    //проверка: число 3-х значное и меньше предыдущего минимального
                    if((fdnumbers[i, j] > 99) & (fdnumbers[i, j] < min))
                    {
                        check = true;
                        min = fdnumbers[i, j];
                    }
                }
            }
            if (check)// проверка есть ли 3-х значное число
                return min;
            else
                return -1;
        }

        /* Задание 3 */
        private int[,] Matrix(int k)
        {
            int[,] modmatrix = new int[N, M - 1];//новый массив для измененной матрицы

            for(int i = 0; i < N; i++)
            {
                for (int j = 0; j < M - 1; j++)
                {
                    if (j < k - 1)//пока не дошли до нужного столбц, ничего не меняем
                        modmatrix[i, j] = matrix[i, j];
                    else
                        modmatrix[i, j] = matrix[i, j + 1]; // пропускаем столбец, кот. нужно вырезать и ставим на его место сдедующий
                }                                
            }
            return modmatrix;
        }

        /* дальше вспомогательные методы и обработчики нажатий на кнопки*/
        void GenerateRand() //метод для заполнения массивов случайными числами
        {
            Random rand = new Random();
            if (Task == 1)//для задания 1
            {
                //генерируем массив
                for (int i = 0; i < N; i++)
                {
                    numbers[i] = rand.Next(-100, 100);
                }
                //выводим в textBox
                richTextBoxMas.Text = "";
                for (int i = 0; i < numbers.Length; i++)
                {
                    richTextBoxMas.Text += numbers[i].ToString() + "; ";
                }
            }
            else if (Task == 2)//для задания 2
            {

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        fdnumbers[i, j] = rand.Next(0, 1000);//генерируем массив
                    }
                }
                //выводим в textBox
                richTextBoxMas.Text = "";
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        richTextBoxMas.Text += fdnumbers[i, j].ToString() + "; ";
                    }
                    richTextBoxMas.Text += "\n";
                }
            }
            else if (Task == 3)//для задания 3
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        matrix[i, j] = rand.Next(-10, 10);//генерируем массив
                    }
                }
                //выводим в textBox
                richTextBoxMas.Text = "";
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        richTextBoxMas.Text += matrix[i, j].ToString() + "; ";
                    }
                    richTextBoxMas.Text += "\n";
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Task = 1;
        }

        /* Кнопка "Решить" */
        private void buttonSolve_Click(object sender, EventArgs e)
        {
            int answer, k;
            if(Task == 1)// задание 1
            {
                answer = ClosestToAverage();//вызываем созданный раннее метод
                //выводим ответ в сплывающее окно
                MessageBox.Show("Ближайший к среднему значению элемент:\n\n" + answer.ToString()); 
            }
            else if (Task == 2)// задание 2
            {
                answer = MinFreedigitNumber();
                //проверка есть ли трехначное число
                if (answer == -1)
                    MessageBox.Show("Нет трехзначных чисел");
                else
                    MessageBox.Show("Минимальное трехзначное число: \n\n" + answer.ToString());
            }
            else if (Task == 3)// задание 2
            {
                k = Convert.ToInt32(textBoxK.Text);//считываем введенное пользователем k
                var modm = Matrix(k);//вызываем метод

                //вывод полученной матрицы в textBox
                richTextBoxMas.Text += "\n";
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M - 1; j++)
                    {
                        richTextBoxMas.Text += modm[i, j].ToString() + "; ";
                    }
                    richTextBoxMas.Text += "\n";
                }
            }
        }

        /*Кнопка ОК после ввода массива*/
        //значения вводятся через пробел в одну строчку
        //для двумерного массива в несколько строчек
        private void buttonOK_Click(object sender, EventArgs e)
        {
            string array;
            array = richTextBoxInput.Text;//считываем введенные данные
            if (Task == 1)//задание 1
            {
                string[] a = array.Split(' ');//разделяем данные на подстроки (ражделитель "пробел")
                numbers = new int[a.Length]; //новая длина массива
                N = numbers.Length;
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = Int32.Parse(a[i]);//parse переводит строковое значение в int
                }
                //выводим массив
                richTextBoxMas.Text = "";
                for (int i = 0; i < numbers.Length; i++)
                {
                    richTextBoxMas.Text += numbers[i].ToString() + "; ";
                }
            }
            else//для 2 и 3 заданий
            {
                string[] a = array.Split('\n');//разделяем по строкам
                string[] b = { "", "" };
                for(int i = 0; i < a.Length; i++)
                {
                    b = a[i].Split(' ');                   
                }
                N = a.Length;
                M = b.Length;
                fdnumbers = new int[N, M];//новый размер массива
                matrix = new int[N, M];
                for (int i = 0; i < N; i++)
                {
                    b = a[i].Split(' ');//разделяем на отдельные числа каждую строку
                    for (int j = 0; j < M; j++)
                    {
                        fdnumbers[i, j] = Int32.Parse(b[j]);//заполняем массив
                        matrix[i, j] = Int32.Parse(b[j]);
                    }
                }
                //вывод массива
                if (Task == 2)
                {
                    
                    richTextBoxMas.Text = "";
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < M; j++)
                        {
                            richTextBoxMas.Text += fdnumbers[i, j].ToString() + "; ";
                        }
                        richTextBoxMas.Text += "\n";
                    }
                }
                if (Task == 2)
                {
                    richTextBoxMas.Text = "";
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < M; j++)
                        {
                            richTextBoxMas.Text += matrix[i, j].ToString() + "; ";
                        }
                        richTextBoxMas.Text += "\n";
                    }
                }
            }
                


        }

        /*Кнопки выбора заданий*/
        private void buttonTask1_Click(object sender, EventArgs e)
        {
            Task = 1;
            numbers = new int[N];
            GenerateRand();
        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            Task = 2;
            fdnumbers = new int[N, M];
            GenerateRand();
        }

        private void buttonTask3_Click(object sender, EventArgs e)
        {
            Task = 3;
            matrix = new int[N, M];
            GenerateRand();
            richTextBoxHelp.Text = "Введите номер столбца";
        }

        /*Кнопка "сгенерировать массив"*/
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            GenerateRand();
        }

        /* Кнопка ОК (установка размера массива)*/
        private void buttonNM_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt32(textBoxN.Text);
            M = Convert.ToInt32(textBoxM.Text);
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}