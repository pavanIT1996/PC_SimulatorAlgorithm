using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace PC_SimulatorAlgorithm
{
    public partial class Selection : Form
    {
        StringBuilder sb = new StringBuilder();     //Random Numbers store
        StringBuilder sb2 = new StringBuilder();    //Sort Numbers store
        string delimeter  = "   ,   ";
        string delimeter2 = "                ";
        int size = 10;
        Random generator = new Random();
        int smallest;
        int number = 0;
        int numInd = 0;
        int number2 = 0;
        int num2Ind = 0;
        string test;
        int final = 0;
        int[] data;
        int i = 0;
       
   

        public Selection()
        {
            InitializeComponent();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {      
            
             if (textBox1.Text=="")
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

                    textBox5.Text = Convert.ToString(sb2.Append("\nSteps Of Selection Sort\n\n"));
                    textBox5.Text = Convert.ToString(sb2.AppendLine(""));
                    textBox5.Text = Convert.ToString(sb2.AppendLine(""));
                    for (i = 0; i < data.Length; i++)
                    {
                        smallest = i;
                        number = data[i];
                        numInd = i;

                        for (int index = i + 1; index < data.Length; index++)
                        {
                            if (data[index] < data[smallest])
                            {
                                smallest = index;

                            }
                            number2 = data[smallest];
                            num2Ind = smallest;
                        }
                        Swap(i, smallest);
                        final = i;
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

            for (int i = 0; i < size; i++)
            {
                textBox5.Text = Convert.ToString(sb2.Append(Convert.ToString(data[i])).Append(delimeter));                                          
            }

        
            if (final == data.Length-1)
            {
                number = 0;
                number2 = 0;
                numInd = 0;
                num2Ind = 0;
                test = "Sorted";
            }
            else
            {
                if (number == number2 || number < number2)
                {
                    test = "Okay";
                    if (number == 0 && number2 ==0)
                    {
                        test = "Array";
                    }
                }
                else
                    test = "Exchange";
            }
            textBox5.Text = Convert.ToString(sb2.Append(delimeter2).Append(numInd+" -- ").Append(number).Append(delimeter2).Append(num2Ind+" -- ").Append(number2).Append(delimeter2).Append(test));
            textBox5.Text = Convert.ToString(sb2.AppendLine(""));
            textBox5.Text = Convert.ToString(sb2.AppendLine(""));
          
        }


        public void Swap(int first, int second)
        {
            int temporary = data[first];
            data[first] = data[second];
            data[second] = temporary;
 
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


     
    
    }
}
