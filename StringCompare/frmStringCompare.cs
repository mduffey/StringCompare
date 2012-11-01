using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringCompare
{
    public partial class frmStringCompare : Form
    {
        public frmStringCompare()
        {
            string mygit = "https://github.com/mduffey/StringCompare";
            InitializeComponent();
            lnkMe.Links.Add(0, mygit.Length, mygit);
        }

        private void ClickedIt(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start((string)lnkMe.Links[0].LinkData);
        }

        private void rtxtString_Changed(object sender, EventArgs e)
        {
            RichTextBox me = (RichTextBox)sender;
            RichTextBox otherGuy = getOtherGuy(me);
            try
            {
                me.SelectionChanged -= rtxtString_SelectionChanged;
                otherGuy.SelectionChanged -= rtxtString_SelectionChanged;
                me.TextChanged -= rtxtString_Changed;
                otherGuy.TextChanged -= rtxtString_Changed;
                int counter = 0;
                string text = otherGuy.Text;
                otherGuy.Text = string.Empty;
                otherGuy.SelectionColor = Color.Black;
                otherGuy.SelectedText = text;
                text = me.Text;
                int position = me.SelectionStart;
                me.Text = string.Empty;
                while (counter < text.Length && counter < otherGuy.Text.Length)
                {
                    if (text[counter] != otherGuy.Text[counter])
                    {
                        me.SelectionColor = Color.Red;
                    }
                    else
                    {
                        me.SelectionColor = Color.Black;
                    }
                    me.SelectedText = text.Substring(counter, 1);
                    counter++;
                }
                me.SelectedText = text.Substring(counter, text.Length - counter);
                me.SelectionStart = position;
            }
            finally
            {
                me.TextChanged += new EventHandler(rtxtString_Changed);
                otherGuy.TextChanged += new EventHandler(rtxtString_Changed);
                me.SelectionChanged += new EventHandler(rtxtString_SelectionChanged);
                otherGuy.SelectionChanged += new EventHandler(rtxtString_SelectionChanged);
            }
            lblOneCount.Text = rtxtStringOne.Text.Length.ToString();
            lblTwoCount.Text = rtxtStringTwo.Text.Length.ToString();
        }

        private void rtxt_KeyDown(object sender, KeyEventArgs e)
        {
            RichTextBox box = (RichTextBox)sender;
            if (e.Control && e.KeyCode.Equals(Keys.V))
            {
                if (Clipboard.ContainsText() || Clipboard.ContainsData(DataFormats.StringFormat))
                    box.Paste(DataFormats.GetFormat(DataFormats.StringFormat));
            }
        }

        private void rtxtString_SelectionChanged(object sender, EventArgs e)
        {
            RichTextBox me = (RichTextBox)sender;
            RichTextBox otherGuy = getOtherGuy(me);
            lblShouldBe.Text = "--";
            if (me.SelectionLength > 0 && otherGuy.Text.Length > me.SelectionStart)
            {
                string metext = me.Text.Substring(me.SelectionStart, me.SelectionLength);
                string othertext;
                if (otherGuy.Text.Length < (me.SelectionStart + me.SelectionLength))
                    othertext = otherGuy.Text.Substring(me.SelectionStart);
                else
                    othertext = otherGuy.Text.Substring(me.SelectionStart, me.SelectionLength);
                if (metext.Substring(0, othertext.Length) != othertext)
                {
                    lblShouldBe.Text = othertext;
                }
            }
        }

        private RichTextBox getOtherGuy(RichTextBox me)
        {
            if (me.Name == "rtxtStringOne")
                return rtxtStringTwo;
            else
                return rtxtStringOne;
        }

    }
}
