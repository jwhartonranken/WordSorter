using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: James Wharton
 * Assn: Chapter 8 Labs part 2
 * This program will alphabetize a phrase,
 * putting capitalized iterations of a word first.
 */

namespace LB4
{
    public partial class FormPhraseSorter : Form
    {
        public FormPhraseSorter()
        {
            InitializeComponent();
        }

        string[] words = new string[0];

        private void buttonSort_Click(object sender, EventArgs e)
        {
            string phrase = textBoxPhrase.Text;

            words = phrase.Split(' ');

            SortWords();

            string sortedPhrase = "";

            foreach(string word in words)
            {
                sortedPhrase += word.Trim() + " ";
            }

            labelSortedPhrase.Text = sortedPhrase;
        }

        private void SortWords()
        {
            Array.Sort(words);

            for(int lcv = 0; lcv < words.Length; lcv++)
            {
                if (lcv < words.Length - 1)
                {
                    if (words[lcv].ToLower() == words[lcv + 1].ToLower())
                    {
                        string lower = words[lcv];
                        string replacement = words[lcv + 1];

                        if (Char.IsUpper(replacement[0]))
                        {
                            
                                words[lcv] = replacement;
                                words[lcv + 1] = lower;
                            
                        }
                    }
                }
            }
            
        }
    }
}
