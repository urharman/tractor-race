using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameRace.Manage;
using System.Media;


namespace GameRace
{
    public partial class TractorRace : Form
    {
        public int players = 3;
        public int counter1 = 0;
        public int flag1 = 0, flag2 = 0, flag3 = 0, flag4 = 0;
        public int num;
        //harmanpreet = new harmanpreet();
        //Bob bob_ob = new Bob();
        //Al al_ob = new Al();
        //instantiate an array of punters and monster
        private Tractor[] Tractor = new Tractor[4];
        private string Winner;

        Player[] myPlayer = new Player[3];
        Player singlePlayer = new Manage.harmanpreet();
        private int tractor;
        

        public TractorRace()
        {
            InitializeComponent();
            //give the punters and monsters some starting values
            Tractor[0] = new Tractor { Length = 0, myPB = Tractor1, Name = "Tractor1" };
            //bind the picturebox to the image
            Tractor[0].myPB.BackgroundImage = Resource1.Tractor1;
            Tractor[1] = new Tractor { Length = 0, myPB = tractor2, Name = "Tractor2" };
            Tractor[1].myPB.BackgroundImage = Resource1.Tractor2;
            Tractor[2] = new Tractor { Length = 0, myPB = tractor3, Name = "Tractor3" };
            Tractor[2].myPB.BackgroundImage = Resource1.Tractor3;
            Tractor[3] = new Tractor { Length = 0, myPB = tractor4, Name = "Tractor4" };
            Tractor[3].myPB.BackgroundImage = Resource1.Tractor4;
            SetUpThePlayer();
        }
        public void SetUpThePlayer()
        {
            for (int i = 0; i < 3; i++)
            {
                myPlayer[i] = work.GetAPlayer(i);
                myPlayer[i].LabelWinner = lblWinner;


            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            if (Manage.harmanpreet.amount == 0)
            {
                numericUpDown1.Value = 1;
                textBox4.Text = Convert.ToString("$" +0);
            }
            else
            {
                numericUpDown1.Maximum = Manage.harmanpreet.amount;
                textBox4.Text = Convert.ToString("$" + Manage.harmanpreet.amount);
            }
        }
        private void radioButton3(object sender, EventArgs e)
        {

            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            if (Manage.gaganpreet.amount == 0)
            {
                numericUpDown1.Value = 1;
                textBox2.Text = Convert.ToString("$" + 0);
            }
            else
            {
                numericUpDown2.Maximum = Manage.gaganpreet.amount;
                textBox2.Text = Convert.ToString("$" + Manage.gaganpreet.amount);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RunRace();
            int i;
            Random r = new Random();
            num = r.Next(1, 5);

            timer1.Enabled = true;
            timer2.Enabled = true;
        }
        private void RadioButton2(object sender, EventArgs e)
        {
            
                numericUpDown1.Value = 1;
                numericUpDown2.Value = 1;
                if (Manage.anil.amount == 0)
                {
                    numericUpDown1.Value = 1;
                    label2.Text = Convert.ToString("$" + 0);
                }
                else
                {
                    numericUpDown2.Maximum = Manage.anil.amount;
                    label2.Text = Convert.ToString("$" + Manage.anil.amount);
                }
            }
            int flag = 0;
        

        private void RunRace()
        {
            bool end = false;
            var myrnd = new Random();

            while (end != true)
            {
                int distance = TractorRace.ActiveForm.Width - Tractor1.Width - 20;

                for (int i = 0; i < 4; i++)
                {
                    Application.DoEvents();
                    Tractor[i].myPB.Left += myrnd.Next(1, 5);

                    if (Tractor[i].myPB.Left > distance)
                    {
                        end = true;
                        Winner = Tractor[i].Name;
                        this.Text = Winner + " " + i.ToString();

                        FindTheWinner();
                    }
                }
            }
        }
        private void textBox1(object sender, EventArgs e)
        {

        }

        private void textBox3(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void lblWinner_Click(object sender, EventArgs e)
        {

        }

        private void FindTheWinner()
        {
            lblWinner.Text = string.Empty;

            for (int j = 0; j < 3; j++)
            {
                if (myPlayer[j].Tractor == Winner)
                {
                    myPlayer[j].Cash += myPlayer[j].Bet;
                    myPlayer[j].LabelWinner.ForeColor = Color.Black;

                    TractorRace.ActiveForm.BackColor = myPlayer[j].MyColor;
                    myPlayer[j].LabelWinner.Text += Winner + " and " + myPlayer[j].PlayerName + " won  and now has " + myPlayer[j].Cash + "";
                }
                else
                {
                    myPlayer[j].Cash -= myPlayer[j].Bet;

                    myPlayer[j].LabelWinner.Text += " " + myPlayer[j].PlayerName + " lost and now has " + myPlayer[j].Cash + " ";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                Tractor[i].myPB.Left = 37;
                Winner = "Tractor Race";
                // this.Text = Winner;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //set some values for the bettors
            // myPlayer[0].Tractor = "Tractor1";
            // myPlayer[1].Tractor = "Tractor2";
            // myPlayer[2].Tractor = "Tractor3";


            //how much have they bet?
            // myPlayer[0].Bet = 50;
            // myPlayer[1].Bet = 50;
            // myPlayer[2].Bet = 50;


            //myPunter[0].LabelWinner.ForeColor = Color.BlueViolet;
            //myPunter[1].LabelWinner.ForeColor = Color.Aquamarine;
            //myPunter[2].LabelWinner.ForeColor = Color.Crimson;
            if (radioButton1.Checked == true)
            {
                if (Manage.harmanpreet.runner != 0)
                {
                    MessageBox.Show("You already placed a bet");
                }
                else
                {
                    textBox5.Text = "Amount After Bet for Harmanpreet";
                    Manage.harmanpreet.amount = Convert.ToInt16(numericUpDown1.Value);
                    Manage.harmanpreet.runner = Convert.ToInt16(numericUpDown2.Value);
                    Manage.harmanpreet.amount = Manage.harmanpreet.amount - Manage.harmanpreet.amount;
                    label2.Text = Manage.harmanpreet.amount.ToString();
                    textBox5.Text = "harmanpreet $" + numericUpDown1.Value + " on runner " + Manage.harmanpreet.runner;
                }
                flag++;
            }
            else if (radiobutton3.Checked == true)
            {
                if (anil.amount != 0)
                {
                    MessageBox.Show("You already placed a bet");
                }
                else
                {
                    label1.Text = "Amount After Bet for Anil";
                    anil.amount = Convert.ToInt16(numericUpDown1.Value);
                    anil.runner = Convert.ToInt16(numericUpDown2.Value);
                    anil.amount = anil.amount - anil.amount;
                    label2.Text = anil.amount.ToString();
                    textBox2.Text = "Anil bets $" + numericUpDown1.Value + " on runner " + anil.runner;
                }
                flag++;
            }
            else if (radioButton2.Checked == true)
            {
                if (gaganpreet.amount != 0)
                {
                    MessageBox.Show("You already placed a bet");
                }
                else
                {
                    textBox4.Text = "Amount After Bet for Gaganpreet";
                    gaganpreet.amount = Convert.ToInt16(numericUpDown1.Value);
                    gaganpreet.runner = Convert.ToInt16(numericUpDown2.Value);
                    gaganpreet.runner = gaganpreet.amount - gaganpreet.amount;
                    label2.Text = gaganpreet.amount.ToString();
                    textBox4.Text = "Gaganpreet bet $" + numericUpDown1.Value + " on runner " + gaganpreet.runner;
                }
                flag++;
            }
            /*if (Tractor == 3)
            {
                button5.Enabled = true;
            }

        }


    
    }

        private void AllRB_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton fakeRB = (RadioButton)sender;

            if (fakeRB.Checked == true)
            {
                //look for the anme of the person your clicked on 
                switch (fakeRB.Text)
                {
                    //instantiate that punter
                    case "Harmanpreet":
                        singlePlayer = work.GetAPlayer(0);
                        break;
                    case "Anil":
                        singlePlayer = work.GetAPlayer(1);
                        break;
                    case "Gaganpreet":
                        singlePlayer = work.GetAPlayer(2);
                        break;
                }

               
            }
        }

        private void udBet_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3(object sender, EventArgs e)
        {

        }

        private void RadioButton2(object sender, EventArgs e)
        {

        }

        private void RadioButton1(object sender, EventArgs e)
        {

        }

        //click on the radiobutton to select a bettor
        */
        }
    }
}

   
