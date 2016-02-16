//Morgan Stock
//POS/409
//instructer: John Becton
//this application simulates duble dice rolls
//it displays a list of all rolls out of 100
//if the roll is a double roll number dice numbers rolled and total need to be shown
//adds a second list of rolled dice then compares the two lists and displays the unique rolls

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoll
{
    public partial class Form1 : Form
    {

        List<string> firstList = new List<string>();
        List<string> secondList = new List<string>();


        Dice dice = new Dice();
        Dice diceSecond = new Dice();
        bool contuneRoll = true;

        BackgroundWorker worker;

        public Form1()
        {
            InitializeComponent();
        }//end Form1

        //exits the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end btnExit_Click

        //on completion of worker resets btnRoll and counter
        private void worker_RunWorkerCompleted()
        {


            contuneRoll = true;
            btnRoll.Invoke(new Action(() => btnRoll.Text = "Roll"));
        }//end worker_RunWorkerCompleted

        //async thread call runs the dice rolling and displaying
        async void diceRollTask(object sender, DoWorkEventArgs e)
        {
            for (int count = 1; count <= 100; count++)
            {
                if (!contuneRoll)
                {
                    int[] rolledNumbers = new int[2];
                    int[] rolledNumbersSecond = new int[2];
                    //gets rolled dice numbers
                    rolledNumbers = dice.Roll();
                    rolledNumbersSecond = diceSecond.Roll();
                    //display dice roll
                    displayDiceImage(rolledNumbers);
                    displayDiceImageSecond(rolledNumbersSecond);

                    //checks for doubles and displays result in list box
                    displayListResult(rolledNumbers, count);
                    displayListResultSecond(rolledNumbersSecond, count);
                    //adds each roll to a list for compareson
                    string firstResult = rolledNumbers[0] + "," + rolledNumbers[1];
                    string secondResult = rolledNumbersSecond[0] + "," + rolledNumbersSecond[1];
                    firstList.Add(firstResult);
                    secondList.Add(secondResult);

                    //refresh display and waits after each dice roll
                    if (!chkDisableList1.Checked || !chkDisableList2.Checked)
                    {
                        this.Invoke(new Action(() => this.Refresh()));
                        //int visibleItems = lstRoll.ClientSize.Height / lstRoll.ItemHeight;
                        //lstRoll.TopIndex = Math.Max(lstRoll.Items.Count - visibleItems + 1, 0);
                        await Task.Delay(500);
                    }
                }
                else
                {
                    break;
                }
            }
            worker_RunWorkerCompleted();
        }

        private void displayListResultSecond(int[] numbers, int count)
        {
            //checks for doubles 
            if (numbers[0] == numbers[1])
            {
                lstRoll2.Invoke(new Action(() => lstRoll2.Items.Add(diceSecond.FormatDouble(count))));
            }
            else
            {
                lstRoll2.Invoke(new Action(() => lstRoll2.Items.Add(diceSecond.Format())));
            }
        }

        private void displayDiceImageSecond(int[] numbers)
        {
            if (!chkDisableList2.Checked)
            {
                Image diceImage1Second = Image.FromFile(diceSecond.diceImage(numbers[0]));
                Image diceImage2Second = Image.FromFile(diceSecond.diceImage(numbers[1]));
                pctDice1List2.Image = diceImage1Second;
                pctDice1List2.SizeMode = PictureBoxSizeMode.CenterImage;
                pctDice2List2.Image = diceImage2Second;
                pctDice2List2.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {

            }
        }

        //displays a list of 100 rolled pair dice
        //
        private void btnRoll_Click(object sender, EventArgs e)
        {
            //async thread process to stop list generation with one button
            if (contuneRoll)
            {
                pctDice1List1.Image = null;
                pctDice2List1.Image = null;
                pctDice1List2.Image = null;
                pctDice2List2.Image = null;
                lstRoll1.Items.Clear();
                lstRoll2.Items.Clear();
                lstExcept.Items.Clear();
                firstList.Clear();
                secondList.Clear();
                btnRoll.Text = "Stop";
                contuneRoll = false;
                worker = new BackgroundWorker();
                worker.DoWork += new DoWorkEventHandler(diceRollTask);
                worker.RunWorkerAsync();
                worker.WorkerSupportsCancellation = true;
            }
            else
            {
                worker.CancelAsync();
                worker = null;
                btnRoll.Text = "Roll";
                contuneRoll = true;

            }

        }
        //display dice roll
        private void displayDiceImage(int[] numbers)
        {
            //checks for disabled graphics check box
            if (!chkDisableList1.Checked)
            {
                Image diceImage1 = Image.FromFile(dice.diceImage(numbers[0]));
                Image diceImage2 = Image.FromFile(dice.diceImage(numbers[1]));
                pctDice1List1.Image = diceImage1;
                pctDice1List1.SizeMode = PictureBoxSizeMode.CenterImage;
                pctDice2List1.Image = diceImage2;
                pctDice2List1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {

            }
        }

        //displays item in list box
        private void displayListResult(int[] numbers, int count)
        {
            //checks for doubles 
            if (numbers[0] == numbers[1])
            {
                lstRoll1.Invoke(new Action(() => lstRoll1.Items.Add(dice.FormatDouble(count))));
            }
            else
            {
                lstRoll1.Invoke(new Action(() => lstRoll1.Items.Add(dice.Format())));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //displays the selected items count
            int count = 0;
            //this is the linq statment that does not work. All sources indicate this is how to process
            //the ling statment, but in thee line item.Selected does not exist and Cast cant change list items into objects
            //there is somthing that is not relayed in every site and example i have located (over 100 examples) or it is
            //just the use of windows forms instead of the more commonely used application platforms like asp or wpf.
            //
            //var selectedCountries = from item in lstRoll1.Items.Cast()
            //                      where item.Selected == true
            //                      select item;

            count = lstRoll1.SelectedItems.Count + lstRoll2.SelectedItems.Count;
            txtSelectedTotal.Text = count.ToString();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            //compares the two lists of rolled dice. Displays the unique rolls in each list
            IEnumerable<string> l1 = firstList.Except(secondList);
            IEnumerable<string> l2 = secondList.Except(firstList);
            List<string> l3 = new List<string>();
            lstExcept.Items.Add("Unique rolls in each list");
            lstExcept.Items.Add("From list One");
            foreach (var item in l1)
            {
                lstExcept.Items.Add(item);
            }
            lstExcept.Items.Add("From list two");
            foreach (var item in l2)
            {
                lstExcept.Items.Add(item);
            }
        }
    }
}


