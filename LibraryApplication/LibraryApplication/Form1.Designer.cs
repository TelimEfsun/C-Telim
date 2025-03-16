namespace LibraryApplication
{
    partial class Form1
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
            this.TextPrice = new System.Windows.Forms.TextBox();
            this.TextGenre = new System.Windows.Forms.TextBox();
            this.TextName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGoster = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TextPrice
            // 
            this.TextPrice.Location = new System.Drawing.Point(373, 26);
            this.TextPrice.Multiline = true;
            this.TextPrice.Name = "TextPrice";
            this.TextPrice.Size = new System.Drawing.Size(122, 31);
            this.TextPrice.TabIndex = 23;
            // 
            // TextGenre
            // 
            this.TextGenre.Location = new System.Drawing.Point(202, 26);
            this.TextGenre.Multiline = true;
            this.TextGenre.Name = "TextGenre";
            this.TextGenre.Size = new System.Drawing.Size(122, 31);
            this.TextGenre.TabIndex = 22;
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(24, 26);
            this.TextName.Multiline = true;
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(122, 31);
            this.TextName.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // BtnGoster
            // 
            this.BtnGoster.BackColor = System.Drawing.Color.Cyan;
            this.BtnGoster.Location = new System.Drawing.Point(521, 148);
            this.BtnGoster.Name = "BtnGoster";
            this.BtnGoster.Size = new System.Drawing.Size(101, 34);
            this.BtnGoster.TabIndex = 17;
            this.BtnGoster.Text = "Display";
            this.BtnGoster.UseVisualStyleBackColor = false;
            this.BtnGoster.Click += new System.EventHandler(this.BtnGoster_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.Red;
            this.BtnSil.Location = new System.Drawing.Point(521, 112);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(101, 34);
            this.BtnSil.TabIndex = 16;
            this.BtnSil.Text = "Remove";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Lime;
            this.BtnAdd.Location = new System.Drawing.Point(18, 63);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 52);
            this.BtnAdd.TabIndex = 15;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 188);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(621, 150);
            this.DataGridView.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(642, 349);
            this.Controls.Add(this.TextPrice);
            this.Controls.Add(this.TextGenre);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGoster);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextPrice;
        private System.Windows.Forms.TextBox TextGenre;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGoster;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView DataGridView;
    }
}

