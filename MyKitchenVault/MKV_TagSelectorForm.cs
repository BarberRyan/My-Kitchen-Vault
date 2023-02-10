﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyKitchenVault
{
    public partial class MKV_TagSelectorForm : Form
    {
        public List<string> Added { get; set; }
        public List<string> Removed { get; set; }
        public List<string> Current { get; set; }

        private readonly List<string> autoTagList = MKV_Main.ac_all_tags;

        public MKV_TagSelectorForm(string title)
        {
            InitializeComponent();
            this.Text = title;
            AutoCompleteStringCollection tags = new AutoCompleteStringCollection();
            tags.AddRange(autoTagList.ToArray());
            tagBox.AutoCompleteCustomSource = tags;
        }

        public MKV_TagSelectorForm(string title, List<string> previous)
        {
            InitializeComponent();
            this.Text = title;
            AutoCompleteStringCollection tags = new AutoCompleteStringCollection();
            tags.AddRange(autoTagList.ToArray());
            tagBox.AutoCompleteCustomSource = tags;
            if (previous != null)
            {
                foreach (string tag in previous)
                {
                    if (autoTagList.Contains(tag))
                    {
                        tagList.Items.Add(tag).BackColor = Color.PaleGreen;
                    }
                    else if (tag.Trim().Length > 0)
                    {
                        tagList.Items.Add(tag).BackColor = Color.PaleVioletRed;
                    }
                    tagBox.Focus();
                }
            }
        }

        /// <summary>
        /// Adds tag to the tag list (fired when the "add tag" button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void AddTagButton_Click(object sender, EventArgs e)
        {
            string newTag = tagBox.Text;

            if (newTag.Length > 0 && tagList.FindItemWithText(newTag) == null)
            {
                if(Added == null)
                {
                    Added = new List<string>();
                }

                tagBox.Text = "";

                if (autoTagList.Contains(newTag))
                {
                    tagList.Items.Add(newTag).BackColor = Color.PaleGreen;
                }
                else
                {
                    tagList.Items.Add(newTag).BackColor = Color.PaleVioletRed;
                }
                Added.Add(newTag);
                tagBox.Focus();
            }
        }

        /// <summary>
        /// Removes tag from the tag list (fired when the "remove selected" button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void RemoveTagButton_Click(object sender, EventArgs e)
        {            
            if (tagList.SelectedItems.Count > 0)
            {
                if(Removed == null)
                {
                    Removed = new List<string>();
                }

                foreach (ListViewItem item in tagList.SelectedItems)
                {
                    Removed.Add(item.Text);
                    tagList.Items.Remove(item);
                }
                errorLabel.Visible = false;
            }
            else
            {
                errorLabel.Visible = true;
            }
        }

        /// <summary>
        /// Removes tag from the tag list (fired when a key is pressed in the tag box)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void TagBoxEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addTagButton.PerformClick();
            }
        }

        /// <summary>
        /// Saves the tag list and closes the form (fired when the "accept" button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            List<string> output = new List<string>();

            if (tagList.Items.Count > 0)
            {
                for (int i = 0; i < tagList.Items.Count; i++)
                {
                    output.Add(tagList.Items[i].Text);
                }

                Current = output;
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Cancels and closes the form (fired when the "cancel" button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Close without saving?", "Are you sure?", MessageBoxButtons.YesNo);
            if (response == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        /// <summary>
        /// Deletes selected tags when delete or backspace is pressed (fired when a key is released)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void TagList_Key_Up(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                removeTagButton.PerformClick();
            }
            else if (char.IsLetter((char)e.KeyCode))
            {
                tagBox.Focus();
                tagBox.Text += (char)e.KeyCode;
            }
        }
    }
}
