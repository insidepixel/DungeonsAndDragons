using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DNDClone
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string getText()
        {
            //First check that the textbox input is not blank or made of just spaces
            if (!string.IsNullOrWhiteSpace(txtInput.Text))
            {
                //Replace non alphanumeric characters with nothing and turn to a char array so we can modify each letter seperately
                Char[] NameArray = txtInput.Text.Where(c => (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))).ToArray();
                if (NameArray.Length > 0)
                {
                    //Make the first letter uppercase
                    NameArray[0] = Char.ToUpper(NameArray[0]);
                    //Make the rest lower case
                    for (int i = 1; i < NameArray.Length; i++)
                    {
                        if (NameArray[i - 1] == Convert.ToChar(" "))
                        {
                            NameArray[i] = Char.ToUpper(NameArray[i]);
                        }
                        else
                        {
                            NameArray[i] = Char.ToLower(NameArray[i]);
                        }
                    }
                    //Put the char array back together in to a string and send it back to Form1
                    return new string(NameArray);
                }
                else
                {
                    return "Adventurer";
                }
            }
            //The string was empty or only contained spaces, return a default name instead
            else
            {
                return "Adventurer";
            }
        }
    }
}