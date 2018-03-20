using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PC_SimulatorAlgorithm
{
    public partial class Insertion : Form
    {
        StringBuilder sb = new StringBuilder();     //Random Numbers store
        StringBuilder sb2 = new StringBuilder();    //Sort Numbers store 
        string delimeter = "   ,   ";
        string delimeter2 = "                ";
        int size = 10;
        Random generator = new Random();
        int number = 0;
        int numInd = 0;
        int number2 = 0;
        int num2Ind = 0;
        string test;
        int[] data;
        int index = 0;
        int j = 0;
        int key;

     
      

        public Insertion()
        {
            InitializeComponent();
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                data = new int[size];
                for (int i = 0; i < size; i++)
                {
                    data[i] = generator.Next(20, 90);
                    textBox1.Text = Convert.ToString(sb.Append(Convert.ToString(data[i])).Append(delimeter));
                }
            }
            else
                MessageBox.Show("Please Clear First to add Random numbers again");
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text != "")
            {
                if (textBox5.Text == "")
                {
                    displayArray();

                    textBox5.Text = Convert.ToString(sb2.Append("\nSteps Of Insertion Sort\n\n"));
                    textBox5.Text = Convert.ToString(sb2.AppendLine(""));
                    textBox5.Text = Convert.ToString(sb2.AppendLine(""));
                    for (j = 1; j < data.Length; j++)
                    {
                        key = data[j];
                        index = j - 1;
                        number = key;
                        numInd = j;
                        number2=data[index];
                        while (index >= 0 && data[index] > key)
                        {
                            number2 = data[index];
                            num2Ind = index;

                            data[index + 1] = data[index];
                            index = index - 1;
                        }
                        data[index+1] = key;
                        displayArray();
                        
                    }
                   
                }
                else
                    MessageBox.Show("Please Clear First to Sort the random numbers again");
            }
            else
                MessageBox.Show("Please Generate random numbers First for sort");

                

        }


        public void displayArray()
        {
            for (int i = 0; i < data.Length; i++)
            {
                
                textBox5.Text = Convert.ToString(sb2.Append(Convert.ToString(data[i])).Append(delimeter));
               
 
            }
            if (number == number2 || number2 < number)
            {
                test = "Okay";
                if (number == 0 && number2 == 0)
                {
                    test = "Array";
                }
            }
            else
                test = "Step by Step";
            textBox5.Text = Convert.ToString(sb2.Append(delimeter2).Append(num2Ind + " -- ").Append(number2).Append(delimeter).Append(numInd+" -- ").Append(number).Append(delimeter2).Append(test));
            textBox5.Text = Convert.ToString(sb2.AppendLine(""));
            textBox5.Text = Convert.ToString(sb2.AppendLine(""));
           
        }


        private void button2_Click(object sender, EventArgs e)
        {
            sb.Clear();
            sb2.Clear();
            textBox1.Text = "";
            textBox5.Text = "";
            data = null;
            number = 0;
            number2 = 0;
            numInd = 0;
            num2Ind = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main f3 = new Main();
            this.Visible = false;
            f3.Visible = true;
            
        }

        private void Insertion_Load(object sender, EventArgs e)
        {

        }


     

    }
}
