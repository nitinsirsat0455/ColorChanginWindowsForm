using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorChanginWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public async Task<string> colorChangeMethod()
        {
            Random random = new Random();
            int numberOfRandomColors = 1000;
            await Task.Run(() =>
            {
                for (int i = 1; i <= numberOfRandomColors; i++)
                {
                    int red = random.Next(0, 255);
                    int green = random.Next(0, 255);  
                    int blue = random.Next(0, 255);

                    btnStart.BackColor = Color.FromArgb(red, green, blue);
                    this.BackColor = Color.FromArgb(red, green, blue);
                    Thread.Sleep(500);
                }
            });
            return "Task Completed";
        }
        private async void btnStart_Click(object sender, EventArgs e)
        {
            var task = await colorChangeMethod();
        }

    }
}
