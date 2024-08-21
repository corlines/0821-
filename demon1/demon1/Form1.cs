using System;

namespace demon1
{
    public partial class Form1 : Form
    {
        List<Label> fruits = new();
        public void makelabel()
        {
            Label apple = new();
            apple.AutoSize = true;
            apple.Location = new Point(351, 80);
            apple.Name = "apple";
            apple.Size = new Size(36, 15);
            apple.TabIndex = 7;
            apple.Text = "apple";
            Controls.Add(apple);
            fruits.Add(apple);
        }

        public Form1()
        {
            InitializeComponent();
        }
        int o = 0, x = 0;
        Random random = new Random();
        bool gameflag;
        private void Form1_Load(object sender, EventArgs e)
        {
            gameflag = true;
            timer1.Interval = 300;
            progressBar1.Value = 100;
            timer2.Interval = 800;


            makelabel();
            timer2.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!gameflag) return;



            char keyChar = (char)e.KeyCode;

            if (listBox1.Items.Contains(keyChar))
            {
                o += 1;
                listBox1.Items.Remove(keyChar);

            }

            else
                x += 1;

            textBox1.Text = "";
            correct.Text = ("맞은개수 : " + o);
            wrong.Text = ("틀린개수 : " + x);
            double percentage = (double)o / (o + x) * 100;

            progressBar1.Value = (int)Math.Truncate(percentage);
            if (o >= 30)
            {
                if (!gameflag) return;
                timer1.Stop();
                Formwin frm = new Formwin();
                frm.ShowDialog();
            }
            else if (x >= 30)
            {


                if (!gameflag) return;
                timer1.Stop();
                Formloss frm = new Formloss();
                frm.ShowDialog();
                gameflag = false;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            char alphabet = (char)(random.Next(26) + 65);

            listBox1.Items.Add(alphabet);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < fruits.Count; i++)
            {
                fruits[i].Top += 20;
                if (fruits[i].Bottom > label2.Top)
                    fruits.Remove(fruits[i]);
            }
                
            
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==  Keys.Enter)
            {
                for(int i = 0; i < fruits.Count; i ++)
                {
                   if (fruits[i].Text == textBox2.Text)
                   {
                       fruits.Remove(fruits[i]);

                   } 
                }
                
            }
        }

        
    }
}
