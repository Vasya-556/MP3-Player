using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3
{
    public partial class Remove : Form
    {
        private Form1 form1;
        private List<string> selectedItems;
        public Remove(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            selectedItems = new List<string>();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            foreach (object item in form1.ComboBox1.Items)
            {
                checkedListBox1.Items.Add(item);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<string> selectedItems = new List<string>();

            // Collect the selected songs from the checkedListBox1
            foreach (var item in checkedListBox1.CheckedItems)
            {
                selectedItems.Add(item.ToString());
            }

            // Remove the selected songs from the ComboBox in Form1
            foreach (var item in selectedItems)
            {
                form1.ComboBox1.Items.Remove(item);
            }

            // Select the next song if available
            if (form1.ComboBox1.Items.Count > 0)
            {
                // Get the index of the removed song
                int removedIndex = checkedListBox1.SelectedIndex;

                // If the removed song was the last one, select the previous song
                if (removedIndex == checkedListBox1.Items.Count - 1)
                {
                    form1.ComboBox1.SelectedIndex = removedIndex - 1;
                }
                // If the removed song was not the last one, select the next song
                else
                {
                    form1.ComboBox1.SelectedIndex = removedIndex;
                }
            }

            // Close the Remove form
            this.Close();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string selectedItem = checkedListBox1.Items[e.Index].ToString();
            if (e.NewValue == CheckState.Checked)
            {
                selectedItems.Add(selectedItem);
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                selectedItems.Remove(selectedItem);
            }
        }
    }
}
