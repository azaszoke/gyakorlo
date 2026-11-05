namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxName = new TextBox();
            this.numAge = new NumericUpDown();
            this.cbxProfession = new ComboBox();
            lblName = new Label();
            lblAge = new Label();
            lblProfession = new Label();
            lbxLista = new ListBox();
            btnAdd = new Button();
            btnDelAll = new Button();
            btnDel = new Button();
            ((System.ComponentModel.ISupportInitialize)this.numAge).BeginInit();
            SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new Point(357, 83);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new Size(121, 23);
            this.tbxName.TabIndex = 0;
            // 
            // numAge
            // 
            this.numAge.Location = new Point(357, 130);
            this.numAge.Name = "numAge";
            this.numAge.Size = new Size(120, 23);
            this.numAge.TabIndex = 1;
            // 
            // cbxProfession
            // 
            this.cbxProfession.FormattingEnabled = true;
            this.cbxProfession.Location = new Point(357, 182);
            this.cbxProfession.Name = "cbxProfession";
            this.cbxProfession.Size = new Size(121, 23);
            this.cbxProfession.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(305, 86);
            lblName.Name = "lblName";
            lblName.Size = new Size(28, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Nev";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(305, 138);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(43, 15);
            lblAge.TabIndex = 4;
            lblAge.Text = "Eletkor";
            // 
            // lblProfession
            // 
            lblProfession.AutoSize = true;
            lblProfession.Location = new Point(305, 185);
            lblProfession.Name = "lblProfession";
            lblProfession.Size = new Size(30, 15);
            lblProfession.TabIndex = 5;
            lblProfession.Text = "Szak";
            // 
            // lbxLista
            // 
            lbxLista.FormattingEnabled = true;
            lbxLista.Location = new Point(116, 237);
            lbxLista.Name = "lbxLista";
            lbxLista.Size = new Size(192, 214);
            lbxLista.TabIndex = 6;
            lbxLista.SelectedIndexChanged += lbxLista_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(356, 239);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(122, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Hozzaadas";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelAll
            // 
            btnDelAll.Location = new Point(356, 297);
            btnDelAll.Name = "btnDelAll";
            btnDelAll.Size = new Size(122, 23);
            btnDelAll.TabIndex = 8;
            btnDelAll.Text = "Torles mind";
            btnDelAll.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(356, 268);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(122, 23);
            btnDel.TabIndex = 9;
            btnDel.Text = "Torles";
            btnDel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDel);
            Controls.Add(btnDelAll);
            Controls.Add(btnAdd);
            Controls.Add(lbxLista);
            Controls.Add(lblProfession);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(this.cbxProfession);
            Controls.Add(this.numAge);
            Controls.Add(this.tbxName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)this.numAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxName;
        private NumericUpDown numAge;
        private ComboBox cbxProfession;
        private Label lblName;
        private Label lblAge;
        private Label lblProfession;
        private ListBox lbxLista;
        private Button btnAdd;
        private Button btnDelAll;
        private Button btnDel;
    }
}
