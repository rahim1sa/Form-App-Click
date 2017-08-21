using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            var LeftPos = 50;
            var TopPos = 80;
            var count = 0;
            for (int j = 0; j < 9; j++)
                    {
                        count += 1;

                        LeftPos += 200;
                        Button btn = new Button();
                        btn.Height = 100;
                        btn.Width = 100;
                        btn.Left = LeftPos;
                        btn.Top = TopPos;
                        btn.BackColor = Color.LightBlue;
                        btn.Text = "Vur banaa!";
                        btn.Click += new System.EventHandler(this.btn_click);

                        Controls.Add(btn);

                if (count==4)
                {
                    LeftPos = 250;
                    count = 1;
                    TopPos += 150;

                    
                    Button btnn = new Button();
                    btn.Height = 100;
                    btn.Width = 100;
                    btn.Left = LeftPos;
                    btn.Top = TopPos;
                    btn.BackColor = Color.LightBlue;
                    btn.Text = "Vur banaa!";
                    btn.Click += new System.EventHandler(this.btn_click);

                    Controls.Add(btn);
                }
                    }
        }
        private void btn_click(object obj,EventArgs arguments)
        {

            Button MyBtn = obj as Button;
            MyBtn.BackColor = Color.Yellow;

            MessageBox.Show("Siz buttona vurdunuz");

        }
    }
}
