using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Linq;


namespace Assignment6_Lists_Linq
{
    public partial class Form1 : Form
    {
        List<string> wordList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAllWords_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string sentence = textBoxSentence.Text;
            foreach (string a in sentence.Split())
            {
                wordList.Add(a.ToLower());
            }
            //string[] dataSource = sentence.Split();
            wordList.Sort();
            foreach (string word in wordList)
            {
                listBox1.Items.Add(word);
            }

        }


        // That that exists exists in that that that that exists exists in
        private void buttonDuplicateWords_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string sentence = textBoxSentence.Text;
            

            string[] dataSource = sentence.ToLower().Split();
            foreach (string aWord in dataSource.Distinct())
            {
                var matchQuery = from word in dataSource
                                 where word == aWord
                                 orderby word descending
                                 select word;

                if (matchQuery.Count() >= 2)
                    listBox2.Items.Add(aWord);
            }

            listBox2.Sorted = true;

        }
    }
}
