namespace ISTA_Exercice
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbName = new TextBox();
            tbPrenom = new TextBox();
            tbAge = new TextBox();
            cbFiliere = new ComboBox();
            btAjouter = new Button();
            btSupprimer = new Button();
            btModifier = new Button();
            btRechercher = new Button();
            Lv = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 92);
            label1.Name = "label1";
            label1.Size = new Size(67, 32);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 153);
            label2.Name = "label2";
            label2.Size = new Size(97, 32);
            label2.TabIndex = 1;
            label2.Text = "Prenom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 213);
            label3.Name = "label3";
            label3.Size = new Size(56, 32);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(183, 277);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 3;
            label4.Text = "Filière";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(557, 363);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 4;
            // 
            // tbName
            // 
            tbName.Location = new Point(324, 91);
            tbName.Name = "tbName";
            tbName.Size = new Size(361, 39);
            tbName.TabIndex = 5;
            // 
            // tbPrenom
            // 
            tbPrenom.Location = new Point(324, 152);
            tbPrenom.Name = "tbPrenom";
            tbPrenom.Size = new Size(361, 39);
            tbPrenom.TabIndex = 6;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(324, 217);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(361, 39);
            tbAge.TabIndex = 7;
            // 
            // cbFiliere
            // 
            cbFiliere.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiliere.FormattingEnabled = true;
            cbFiliere.Location = new Point(324, 276);
            cbFiliere.Name = "cbFiliere";
            cbFiliere.Size = new Size(361, 40);
            cbFiliere.TabIndex = 8;
            cbFiliere.SelectedIndexChanged += cbFiliere_SelectedIndexChanged;
            // 
            // btAjouter
            // 
            btAjouter.Location = new Point(767, 85);
            btAjouter.Name = "btAjouter";
            btAjouter.Size = new Size(199, 46);
            btAjouter.TabIndex = 9;
            btAjouter.Text = "Ajouter";
            btAjouter.UseVisualStyleBackColor = true;
            btAjouter.Click += btAjouter_Click;
            // 
            // btSupprimer
            // 
            btSupprimer.Location = new Point(767, 150);
            btSupprimer.Name = "btSupprimer";
            btSupprimer.Size = new Size(199, 46);
            btSupprimer.TabIndex = 10;
            btSupprimer.Text = "Supprimer";
            btSupprimer.UseVisualStyleBackColor = true;
            btSupprimer.Click += btSupprimer_Click;
            // 
            // btModifier
            // 
            btModifier.Location = new Point(767, 213);
            btModifier.Name = "btModifier";
            btModifier.Size = new Size(199, 46);
            btModifier.TabIndex = 11;
            btModifier.Text = "Modifier";
            btModifier.UseVisualStyleBackColor = true;
            btModifier.Click += btModifier_Click;
            // 
            // btRechercher
            // 
            btRechercher.Location = new Point(767, 275);
            btRechercher.Name = "btRechercher";
            btRechercher.Size = new Size(199, 46);
            btRechercher.TabIndex = 12;
            btRechercher.Text = "Rechercher";
            btRechercher.UseVisualStyleBackColor = true;
            btRechercher.Click += btRechercher_Click;
            // 
            // Lv
            // 
            Lv.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            Lv.GridLines = true;
            Lv.Location = new Point(45, 363);
            Lv.Name = "Lv";
            Lv.Size = new Size(1063, 339);
            Lv.TabIndex = 13;
            Lv.UseCompatibleStateImageBehavior = false;
            Lv.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nom";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Prenom";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Age";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Filiere";
            columnHeader4.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 743);
            Controls.Add(Lv);
            Controls.Add(btRechercher);
            Controls.Add(btModifier);
            Controls.Add(btSupprimer);
            Controls.Add(btAjouter);
            Controls.Add(cbFiliere);
            Controls.Add(tbAge);
            Controls.Add(tbPrenom);
            Controls.Add(tbName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbName;
        private TextBox tbPrenom;
        private TextBox tbAge;
        private ComboBox cbFiliere;
        private Button btAjouter;
        private Button btSupprimer;
        private Button bt;
        private Button btRechercher;
        private Button btModifier;
        private ListView Lv;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}