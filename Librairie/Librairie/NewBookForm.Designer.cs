namespace Librairie
{
    partial class NewBookForm
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
            txtTitle = new TextBox();
            txtIsbn = new TextBox();
            txtPublisher = new TextBox();
            txtAuthor = new TextBox();
            txtCategory = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 34);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(314, 23);
            txtTitle.TabIndex = 0;
            txtTitle.TextChanged += textBox1_TextChanged;
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(12, 92);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(314, 23);
            txtIsbn.TabIndex = 1;
            txtIsbn.TextChanged += textBox2_TextChanged;
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(12, 150);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(314, 23);
            txtPublisher.TabIndex = 2;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(12, 208);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(314, 23);
            txtAuthor.TabIndex = 3;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(12, 266);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(314, 23);
            txtCategory.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 5;
            label1.Text = "Titre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "ISBN :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 7;
            label3.Text = "Editeur :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 183);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 8;
            label4.Text = "Auteur :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 241);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 9;
            label5.Text = "Categorie :";
            // 
            // button2
            // 
            button2.Location = new Point(251, 332);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Annuler";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(160, 332);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "Créer";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // NewBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 371);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCategory);
            Controls.Add(txtAuthor);
            Controls.Add(txtPublisher);
            Controls.Add(txtIsbn);
            Controls.Add(txtTitle);
            Name = "NewBookForm";
            Text = "Ajouter Livre";
            Load += NewBookForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtIsbn;
        private TextBox txtPublisher;
        private TextBox txtAuthor;
        private TextBox txtCategory;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private Button button3;
    }
}