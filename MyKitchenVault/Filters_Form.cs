using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyKitchenVault
{
    public partial class Filters_Form : Form
    {
        public List<string> IncludeTags { get; set; }
        public List<string> ExcludeTags { get; set; }
        public int rating { get; set; }
        public FilterStyle FilterStyle { get; set; }
        public List<string> tagList = Mkv_Main.ac_all_tags;
        

        public Filters_Form()
        {
            //initialization
            InitializeComponent();
            ratingBox.SelectedIndex = 0;

            //populate form if filter data is available
            PopulateForm();


            //populate autocomplete lists
            AutoCompleteStringCollection tags = new AutoCompleteStringCollection();
            tags.AddRange(tagList.ToArray());
            includeBox.AutoCompleteCustomSource = tags;
            excludeBox.AutoCompleteCustomSource = tags;
        }

        /// <summary>
        /// Adds tag to include list (fired when "include tag" button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void IncludeButton_Click(object sender, EventArgs e)
        {
            string includeTag = includeBox.Text;

            if(includeTag.Length > 0 && excludeList.FindItemWithText(includeTag) != null)
            {
                bothErrorLabel.Visible = true;
            }
            else if (includeTag.Length > 0 && includeList.FindItemWithText(includeTag) == null)
            {
                includeBox.Text = "";
                if (tagList.Contains(includeTag))
                {
                    includeList.Items.Add(includeTag).ForeColor = Color.Black;
                }
                else
                {
                    includeList.Items.Add(includeTag).ForeColor = Color.Red;
                }
                bothErrorLabel.Visible = false;
                includeBox.Focus();
            }

            if (!matchAnyRadio.Checked && !matchAllRadio.Checked && includeList.Items.Count > 0)
            {
                matchAnyRadio.Checked = true;
                matchAnyRadio.Enabled = true;
                matchAllRadio.Enabled = true;
            }
        }

        /// <summary>
        /// Removes tag from include list or shows "no tag selected error" (fired when the "remove selected" button is pressed under the include list)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void IncludeRemoveButton_Click(object sender, EventArgs e)
        {
            if(includeList.SelectedItems.Count > 0)
            {
                foreach(ListViewItem item in includeList.SelectedItems)
                {
                    includeList.Items.Remove(item);
                }
            }
            else
            {
                includeErrorLabel.Visible = true;
            }

            if (includeList.Items.Count == 0)
            {
                matchAnyRadio.Checked = false;
                matchAnyRadio.Enabled = false;
                matchAllRadio.Checked = false;
                matchAllRadio.Enabled = false;
            }
        }

        /// <summary>
        /// Removes "no tag selected" error label on the include list (fired when a tag is selected)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void IncludeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            includeErrorLabel.Visible = false;
        }

        /// <summary>
        /// Simulates clicking "include tag" button when enter is pressed in the include text box
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void IncludeBoxEnter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                includeButton.PerformClick();
            }
        }

        /// <summary>
        /// Adds tag to exclude list (fired when "exclude tag" button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void ExcludeButton_Click(object sender, EventArgs e)
        {
            string excludeTag = excludeBox.Text.Trim();
            if (excludeTag.Length > 0 && includeList.FindItemWithText(excludeTag) != null)
            {
                bothErrorLabel.Visible = true;
            }
            else if (excludeTag.Length > 0 && excludeList.FindItemWithText(excludeTag) == null)
            {
                excludeBox.Text = "";
                if (tagList.Contains(excludeTag))
                {
                    excludeList.Items.Add(excludeTag).ForeColor = Color.Black;
                }
                else
                {
                    excludeList.Items.Add(excludeTag).ForeColor = Color.Red;
                }
                bothErrorLabel.Visible = false;
                excludeBox.Focus();
            }
        }

        /// <summary>
        /// Removes tag from exclude list or shows "no tag selected error" (fired when the "remove selected" button is pressed under the exclude list)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void ExcludeRemoveButton_Click(object sender, EventArgs e)
        {
            if (excludeList.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in excludeList.SelectedItems)
                {
                    excludeList.Items.Remove(item);
                }
            }
            else
            {
                excludeErrorLabel.Visible = true;
            }
        }

        /// <summary>
        /// Removes "no tag selected" error label on the exclude list (fired when a tag is selected)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void ExcludeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            excludeErrorLabel.Visible = false;
        }

        /// <summary>
        /// Simulates clicking "exclude tag" button when enter is pressed in the exclude text box
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void ExcludeBoxEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                excludeButton.PerformClick();
            }
        }

        /// <summary>
        /// Submits form and returns filter data (fired when accept button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            List<string> include = new List<string>();
            List<string> exclude = new List<string>();

            if (includeList.Items.Count > 0)
            {
                for (int i = 0; i < includeList.Items.Count; i++)
                {
                    include.Add(includeList.Items[i].Text);
                }

                IncludeTags = include;
            }
            if(excludeList.Items.Count > 0)
            {
                for(int i = 0; i < excludeList.Items.Count; i++)
                {
                    exclude.Add(excludeList.Items[i].Text);
                }

                ExcludeTags = exclude;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Cancels the form and clears filter data (fired when cancel button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Close and clear filters?", "Are you sure?", MessageBoxButtons.YesNo);
            if(response == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        /// <summary>
        /// Sets rating filter to match the selected index of the combobox (fired when the ratingBox index changes)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void RatingBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rating = ratingBox.SelectedIndex;
        }

        /// <summary>
        /// Updates selected filter style (fired when a radio button is selected)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void RadioButtonSelected(object sender, EventArgs e)
        {
            if (matchAnyRadio.Checked)
            {
                FilterStyle = FilterStyle.matchAny;
            }
            else if (matchAllRadio.Checked)
            {
                FilterStyle = FilterStyle.matchAll;
            }           
            else
            {
                FilterStyle = FilterStyle.none;
            }
        }

        /// <summary>
        /// Fill in selected filters when the form is reopened
        /// </summary>
        private void PopulateForm()
        {
            if(Mkv_Main.includeTags != null)
            {
                foreach(string tag in Mkv_Main.includeTags)
                {
                    if (tagList.Contains(tag))
                    {
                        includeList.Items.Add(tag);
                    }
                    else
                    {
                        includeList.Items.Add(tag).ForeColor = Color.Red; 
                    }
                }

                matchAnyRadio.Enabled = true;
                matchAllRadio.Enabled = true;

                switch (Mkv_Main.filterStyle)
                {
                    default:
                    case FilterStyle.matchAny:
                        matchAnyRadio.Checked = true;
                        break;

                    case FilterStyle.matchAll:
                        matchAllRadio.Checked = true;
                        break;
                }
            }

            if(Mkv_Main.excludeTags != null)
            {
                foreach(string tag in Mkv_Main.excludeTags)
                {
                    excludeList.Items.Add(tag);
                }
            }

            if(Mkv_Main.rating != 0)
            {
                ratingBox.SelectedIndex = (int)Mkv_Main.rating;
            }
        }


    }
}
