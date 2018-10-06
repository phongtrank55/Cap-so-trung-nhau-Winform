using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timcapsotrungnhau
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        Panel pn = new Panel();
        private const int n = 24, time = 70;
        private int[] a = new int[n];
        private int t=time, count=0, time_wait;
        private void Form1_Load(object sender, EventArgs e)
        {
            Create_button();
            lbltime.Text = time.ToString();
            timer_wait.Interval = 400;
            timer_run.Interval = 1000;
            Init();
            setcontrol(false);
        }
        private void Create_button()
        {
            int i, j, top=13, left, count = 0;
            pn.Name = "panel1";
            pn.TabStop = false;
            pn.Size = new Size(581, 256);
            pn.Dock = DockStyle.Bottom;
            pn.BackColor = Color.PowderBlue;
            for (i = 0; i < 4; i++)
            {
                left = 15;
                for (j = 0; j < n / 4; j++)
                {
                    Button btn = new Button();
                    btn.Name = "btn0" + count.ToString();
                    count++;
                    btn.Size = new Size(82, 52);
                    btn.Text = "?";
                    btn.Font = new Font(btn.Font.Name, 20, btn.Font.Style);
                    btn.Top = top;
                    btn.Left = left;
                    left+= 90;
                    btn.BackColor = Color.GreenYellow;
                    btn.Click += new EventHandler(btn_Click);
                    btn.TabStop = false;
                    pn.Controls.Add(btn);
                }
                top += 60;
            }
        
            this.Controls.Add(pn);
        }
    
        private void Init()
        {
            int i, j = 100, k, temp;
            //khoi tao
            for (i = 0; i < n / 2; i++)
            {
                do
                {
                    a[i] = (new Random()).Next(0, 9);

                } while (a[i] == j);
                j = a[n - i - 1] = a[i];

            }
            //trao doi
            for (i = 0; i < n / 2; i++)
            {
                j = (new Random()).Next(0, n - 1);
                k = (new Random()).Next(0, n - 1);
                temp = a[k];
                a[k] = a[j];
                a[j] = temp;
            }
        }
        
        private void timer_run_Tick(object sender, EventArgs e)
        {
            t--;
            lbltime.Text = t.ToString();
            if (t == 0)
            {
                timer_run.Enabled = false;
                MessageBox.Show("Hết giờ!\nBạn đã thua!", "Rất tiếc!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Restart();
            }
        }
        private void setcontrol(bool start)
        {
            timer_run.Enabled = start;
            btnstop.Enabled = start;
            pn.Enabled = start;
            btnpause.Enabled = start;
            btnstart.Enabled = !start;
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            setcontrol(true);
        }

        private void btnpause_Click(object sender, EventArgs e)
        {

            setcontrol(false);
            btnstop.Enabled = true;
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        Button button1=null, button2=null;
        private void btn_Click(object sender, EventArgs e)
        {
//            ((Button)sender).
            ((Button)sender).BackColor = Color.LemonChiffon;
            string name = ((Button)sender).Name.ToString();
            string s = name.Substring(name.Length - 2);
            int k = int.Parse(s);
            ((Button)sender).ForeColor = Color.Red;
            ((Button)sender).Text = a[k].ToString();
            if(button1==null || button1==(Button)sender)
            {
                button1 = (Button)sender;
            }
            else
            {
                button2 = (Button)sender;
            }
            if(button1!=null && button2!=null)
            {
                time_wait = 1;
                timer_wait.Start();
            }
        }
        
        private void timer_wait_Tick(object sender, EventArgs e)
        {
            this.Enabled = false;
            if(time_wait==0)
            {
                if(button1.Text != button2.Text)
                {
                    button1.BackColor = button2.BackColor = Color.GreenYellow;
                    button1.ForeColor = button2.ForeColor = Color.Black;
                    button1.Text = button2.Text = "?";
                }
                else
                {
                    button1.BackColor = button2.BackColor = Color.CadetBlue;
                    count++;
                    button2.Enabled = button1.Enabled = false;
                }
                button1 = button2 = null;
                this.Enabled = true;
                timer_wait.Stop();
            }
            time_wait--;
            if(count==n/2)
            {
                timer_run.Enabled = false;
                MessageBox.Show("Bạn đã thắng!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }


        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
