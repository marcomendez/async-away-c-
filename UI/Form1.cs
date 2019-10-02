using MyCustomLibrary;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int time = 2000;
        private async void ReadFileBtn_Click(object sender, EventArgs e)
        {
            var textList = ReaderFile.ReadFile("E:\\test01.txt");

            foreach (string item in textList)
            {
                lbl_view_text.Text = item + " with delay " + time ;
                await Task.Delay(time);
            }
        }

        private void readFileBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                time += 1000;
            }
            if (e.KeyData == Keys.B)
            {
                time -= 1000;
            }
            if (time <= 0)
            {
                time = 1000;
            }
            label1.Text = "Delay : " + time;
        }










        //int counter = 0;

        //int quantityTime = 1000;

        //private async void button1_Click(object sender, EventArgs e)
        //{
        //    counter++;
        //    button1.Text = "Long task started" + counter.ToString();

        //    await LongTask.Start(quantityTime, button1.Text);
        //    quantityTime += 2000;

        //    counter--;
        //    // button1.Text = "Long task end" + counter.ToString();
        //}


    }
}
