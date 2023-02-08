using System.Windows.Forms;

namespace MyKitchenVault
{
    partial class RecipeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeView));
            this.nameLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.descTitleLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ingrLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userRatingLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.star5 = new System.Windows.Forms.PictureBox();
            this.star4 = new System.Windows.Forms.PictureBox();
            this.star3 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            this.star1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.favStar = new System.Windows.Forms.PictureBox();
            this.ratingPanel = new System.Windows.Forms.Label();
            this.instLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tagLabel = new System.Windows.Forms.Label();
            this.starList = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favStar)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(188, 31);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Recipe Name";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.BackColor = System.Drawing.Color.Transparent;
            this.userLabel.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.userLabel.Location = new System.Drawing.Point(3, 31);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(106, 21);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "User Name";
            // 
            // descTitleLabel
            // 
            this.descTitleLabel.AutoSize = true;
            this.descTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.descTitleLabel.Font = new System.Drawing.Font("Lucida Handwriting", 14F);
            this.descTitleLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.descTitleLabel.Location = new System.Drawing.Point(3, 144);
            this.descTitleLabel.Name = "descTitleLabel";
            this.descTitleLabel.Size = new System.Drawing.Size(130, 24);
            this.descTitleLabel.TabIndex = 2;
            this.descTitleLabel.Text = "Description";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.BackColor = System.Drawing.Color.Transparent;
            this.descLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.descLabel.Location = new System.Drawing.Point(3, 168);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(80, 15);
            this.descLabel.TabIndex = 3;
            this.descLabel.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(3, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingredients";
            // 
            // ingrLabel
            // 
            this.ingrLabel.AutoSize = true;
            this.ingrLabel.BackColor = System.Drawing.Color.Transparent;
            this.ingrLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingrLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.ingrLabel.Location = new System.Drawing.Point(3, 207);
            this.ingrLabel.Name = "ingrLabel";
            this.ingrLabel.Size = new System.Drawing.Size(78, 15);
            this.ingrLabel.TabIndex = 5;
            this.ingrLabel.Text = "Ingredients";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Controls.Add(this.nameLabel);
            this.flowLayoutPanel1.Controls.Add(this.userLabel);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.descTitleLabel);
            this.flowLayoutPanel1.Controls.Add(this.descLabel);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.ingrLabel);
            this.flowLayoutPanel1.Controls.Add(this.ratingPanel);
            this.flowLayoutPanel1.Controls.Add(this.instLabel);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.tagLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(450, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(685, 361);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userRatingLabel);
            this.panel1.Controls.Add(this.ratingLabel);
            this.panel1.Controls.Add(this.star5);
            this.panel1.Controls.Add(this.star4);
            this.panel1.Controls.Add(this.star3);
            this.panel1.Controls.Add(this.star2);
            this.panel1.Controls.Add(this.star1);
            this.panel1.Location = new System.Drawing.Point(3, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 40);
            this.panel1.TabIndex = 10;
            // 
            // userRatingLabel
            // 
            this.userRatingLabel.AutoSize = true;
            this.userRatingLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRatingLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.userRatingLabel.Location = new System.Drawing.Point(200, 22);
            this.userRatingLabel.Name = "userRatingLabel";
            this.userRatingLabel.Size = new System.Drawing.Size(96, 18);
            this.userRatingLabel.TabIndex = 17;
            this.userRatingLabel.Text = "User Rating";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.ratingLabel.Location = new System.Drawing.Point(200, 0);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(57, 18);
            this.ratingLabel.TabIndex = 16;
            this.ratingLabel.Text = "Rating";
            // 
            // star5
            // 
            this.star5.BackColor = System.Drawing.Color.Transparent;
            this.star5.Location = new System.Drawing.Point(162, 0);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(40, 40);
            this.star5.TabIndex = 15;
            this.star5.TabStop = false;
            this.star5.Click += new System.EventHandler(this.Star_Click);
            this.star5.MouseLeave += new System.EventHandler(this.Star_Mouse_Leave);
            this.star5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Star_Mouse_Move);
            // 
            // star4
            // 
            this.star4.Location = new System.Drawing.Point(123, 0);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(40, 40);
            this.star4.TabIndex = 14;
            this.star4.TabStop = false;
            this.star4.Click += new System.EventHandler(this.Star_Click);
            this.star4.MouseLeave += new System.EventHandler(this.Star_Mouse_Leave);
            this.star4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Star_Mouse_Move);
            // 
            // star3
            // 
            this.star3.Location = new System.Drawing.Point(84, 0);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(40, 40);
            this.star3.TabIndex = 13;
            this.star3.TabStop = false;
            this.star3.Click += new System.EventHandler(this.Star_Click);
            this.star3.MouseLeave += new System.EventHandler(this.Star_Mouse_Leave);
            this.star3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Star_Mouse_Move);
            // 
            // star2
            // 
            this.star2.Location = new System.Drawing.Point(45, 0);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(40, 40);
            this.star2.TabIndex = 12;
            this.star2.TabStop = false;
            this.star2.Click += new System.EventHandler(this.Star_Click);
            this.star2.MouseLeave += new System.EventHandler(this.Star_Mouse_Leave);
            this.star2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Star_Mouse_Move);
            // 
            // star1
            // 
            this.star1.Location = new System.Drawing.Point(6, 0);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(40, 40);
            this.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star1.TabIndex = 11;
            this.star1.TabStop = false;
            this.star1.Click += new System.EventHandler(this.Star_Click);
            this.star1.MouseLeave += new System.EventHandler(this.Star_Mouse_Leave);
            this.star1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Star_Mouse_Move);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.favStar);
            this.panel2.Location = new System.Drawing.Point(3, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 40);
            this.panel2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(43, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Favorite";
            // 
            // favStar
            // 
            this.favStar.InitialImage = null;
            this.favStar.Location = new System.Drawing.Point(6, 0);
            this.favStar.Name = "favStar";
            this.favStar.Size = new System.Drawing.Size(40, 40);
            this.favStar.TabIndex = 0;
            this.favStar.TabStop = false;
            this.favStar.Click += new System.EventHandler(this.FavStar_Click);
            this.favStar.MouseLeave += new System.EventHandler(this.FavStar_Mouse_Leave);
            this.favStar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FavStar_Mouse_Move);
            // 
            // ratingPanel
            // 
            this.ratingPanel.AutoSize = true;
            this.ratingPanel.BackColor = System.Drawing.Color.Transparent;
            this.ratingPanel.Font = new System.Drawing.Font("Lucida Handwriting", 14F);
            this.ratingPanel.ForeColor = System.Drawing.SystemColors.Info;
            this.ratingPanel.Location = new System.Drawing.Point(3, 222);
            this.ratingPanel.Name = "ratingPanel";
            this.ratingPanel.Size = new System.Drawing.Size(139, 24);
            this.ratingPanel.TabIndex = 6;
            this.ratingPanel.Text = "Instructions";
            // 
            // instLabel
            // 
            this.instLabel.AutoSize = true;
            this.instLabel.BackColor = System.Drawing.Color.Transparent;
            this.instLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.instLabel.Location = new System.Drawing.Point(3, 246);
            this.instLabel.Name = "instLabel";
            this.instLabel.Size = new System.Drawing.Size(82, 15);
            this.instLabel.TabIndex = 7;
            this.instLabel.Text = "Instructions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(3, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tags";
            // 
            // tagLabel
            // 
            this.tagLabel.AutoSize = true;
            this.tagLabel.BackColor = System.Drawing.Color.Transparent;
            this.tagLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.tagLabel.Location = new System.Drawing.Point(3, 285);
            this.tagLabel.Name = "tagLabel";
            this.tagLabel.Size = new System.Drawing.Size(36, 15);
            this.tagLabel.TabIndex = 9;
            this.tagLabel.Text = "Tags";
            // 
            // starList
            // 
            this.starList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("starList.ImageStream")));
            this.starList.TransparentColor = System.Drawing.Color.Transparent;
            this.starList.Images.SetKeyName(0, "empty.png");
            this.starList.Images.SetKeyName(1, "half.png");
            this.starList.Images.SetKeyName(2, "whole.png");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(162, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RecipeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(685, 361);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecipeView";
            this.Text = "RecipeView";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favStar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label descTitleLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label ingrLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label ratingPanel;
        private System.Windows.Forms.Label instLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tagLabel;
        private Panel panel1;
        private ImageList starList;
        private PictureBox star1;
        private PictureBox star5;
        private PictureBox star4;
        private PictureBox star3;
        private PictureBox star2;
        private Label ratingLabel;
        private Label userRatingLabel;
        private Panel panel2;
        private Label label1;
        private PictureBox favStar;
        private Button button1;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}