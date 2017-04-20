using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{   
    public partial class Form1 : Form
    {
        int h;
        int m;
        int s;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            h = Convert.ToInt32(numericUpDown1.Value);
            m = Convert.ToInt32(numericUpDown2.Value);
            s = Convert.ToInt32(numericUpDown3.Value);



            if (h <= 0 || h > 180 || m <= 0 || m > 59 || s <= 0 || s > 59)
            {
                MessageBox.Show("Valores no validos", "No se pudo guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {



                if (h < 10 & m < 10 & s < 10)
                {
                    lbl1.Text = ("0" + h);
                    lbl2.Text = ("0" + m);
                    lbl3.Text = ("0" + s);
                }

                if (m < 10 & s < 10)
                {
                    lbl1.Text = ("" + h);
                    lbl2.Text = ("0" + m);
                    lbl3.Text = ("0" + s);

                }
                if (m > 10 & s < 10)
                {

                    lbl1.Text = ("" + h);
                    lbl2.Text = ("" + m);
                    lbl3.Text = ("0" + s);

                }


                if (s >= 10)
                {
                    lbl1.Text = ("" + h);
                    lbl2.Text = ("" + m);
                    lbl3.Text = ("" + s);

                }
                if (h < 10)
                {
                    lbl1.Text = ("0" + h);

                }
                if (m < 10)
                {
                    lbl2.Text = ("0" + m);

                }
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;

                button2.Visible = true;
                button3.Enabled = true;
                button2.Enabled = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            button4.Visible = false;


            button2.Visible = false;

            button1.Visible = true;

            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (h > 0 & m == 0)
            {
                h = h - 1;

                m = 60;

            }

            if (s != 0)
            {

                s = s - 1;


            }
            else {

                s = 59;

                m = m - 1;
            }


//Impresiones...................................

            if (h < 10 & m < 10 & s < 10)
            {
                lbl1.Text = ("0" + h);
                lbl2.Text = ("0" + m);
                lbl3.Text = ("0" + s);
            }

            if (m < 10 & s < 10)
            {
                lbl1.Text = ("" + h);
                lbl2.Text = ("0" + m);
                lbl3.Text = ("0" + s);

            }
            if (m > 10 & s < 10)
            {

                lbl1.Text = ("" + h);
                lbl2.Text = ("" + m);
                lbl3.Text = ("0" + s);

            }


            if (s > 10)
            {
                lbl1.Text = ("" + h);
                lbl2.Text = ("" + m);
                lbl3.Text = ("" + s);

            }
            if (h < 10)
            {
                lbl1.Text = ("0" + h);

            }
            if (m < 10)
            {
                lbl2.Text = ("0" + m);

            }
            if (h == 0 & m < 1) {

                lbl1.ForeColor=System.Drawing.Color.Red;
                lbl2.ForeColor = System.Drawing.Color.Red;
                lbl3.ForeColor = System.Drawing.Color.Red;

            }

            if (m > 1)
            {

                lbl1.ForeColor = System.Drawing.Color.Black;
                lbl2.ForeColor = System.Drawing.Color.Black;
                lbl3.ForeColor = System.Drawing.Color.Black;



            }

            if (h == 0 & m == 0 & s == 0) {

                timer1.Stop();

                

                try
                {

                    SoundPlayer alarm = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.Free_Converter_com_school_bell_ringing___sound_effect_1_2625627);

                    alarm.Play(); 
                }
                catch
                {


                    MessageBox.Show("Un Error Ha Ocurrido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

                MessageBox.Show("Tiempo Finalizado", "Fin Del Tiempo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Application.Restart();

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled=true;

            button3.Visible = false;
            button4.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button2.Enabled = true;
        }
    }
}
