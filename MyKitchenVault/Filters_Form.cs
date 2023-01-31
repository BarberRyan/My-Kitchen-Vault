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
        public FilterStyle FilterStyle { get; set; }
        
        public List<string> tagList = Mkv_Main.ac_all_tags;

        public Filters_Form()
        {
            InitializeComponent();

            PopulateForm();

            AutoCompleteStringCollection tags = new AutoCompleteStringCollection();
            tags.AddRange(tagList.ToArray());
            includeBox.AutoCompleteCustomSource = tags;
            excludeBox.AutoCompleteCustomSource = tags;
        }

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

            if (!matchAnyRadio.Checked && !matchAllRadio.Checked && !includeOnlySelectedRadio.Checked && includeList.Items.Count > 0)
            {
                matchAnyRadio.Checked = true;
                matchAnyRadio.Enabled = true;
                matchAllRadio.Enabled = true;
                includeOnlySelectedRadio.Enabled = true;
            }
        }

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
                includeOnlySelectedRadio.Checked = false;
                includeOnlySelectedRadio.Enabled = false;
            }
        }

        private void IncludeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            includeErrorLabel.Visible = false;
        }

        private void IncludeBoxEnter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                includeButton.PerformClick();
            }
        }

        private void ExcludeButton_Click(object sender, EventArgs e)
        {
            string excludeTag = excludeBox.Text;
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

        private void ExcludeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            excludeErrorLabel.Visible = false;
        }

        private void ExcludeBoxEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                excludeButton.PerformClick();
            }
        }

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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Close and clear filters?", "Are you sure?", MessageBoxButtons.YesNo);
            if(response == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

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
            else if (includeOnlySelectedRadio.Checked)
            {
                FilterStyle = FilterStyle.includeOnlySelected;
            }
            else
            {
                FilterStyle = FilterStyle.none;
            }
        }

        private void PopulateForm()
        {
            if(Mkv_Main.includeTags != null)
            {
                foreach(string tag in Mkv_Main.includeTags)
                {
                    includeList.Items.Add(tag);
                }

                matchAnyRadio.Enabled = true;
                matchAllRadio.Enabled = true;
                includeOnlySelectedRadio.Enabled = true;

                switch (Mkv_Main.filterStyle)
                {
                    default:
                    case FilterStyle.matchAny:
                        matchAnyRadio.Checked = true;
                        break;

                    case FilterStyle.matchAll:
                        matchAllRadio.Checked = true;
                        break;

                    case FilterStyle.includeOnlySelected:
                        includeOnlySelectedRadio.Checked = true;
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
        }

    }
}
