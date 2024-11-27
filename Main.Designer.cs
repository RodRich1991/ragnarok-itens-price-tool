namespace RagnarokItensPriceTool
{
    partial class Main
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
            panel1 = new Panel();
            btn_Start = new Button();
            chb_ChangeSell = new CheckBox();
            chb_ChangeBuy = new CheckBox();
            lbl_PrecoChxboxes = new Label();
            rb_PercentPlus = new RadioButton();
            rb_PercentMinus = new RadioButton();
            lbl_percentv = new Label();
            nud_percent = new NumericUpDown();
            lbl_Percent = new Label();
            Btn_FilePath = new Button();
            Txb_FilePath = new TextBox();
            lbl_File = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_percent).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btn_Start);
            panel1.Controls.Add(chb_ChangeSell);
            panel1.Controls.Add(chb_ChangeBuy);
            panel1.Controls.Add(lbl_PrecoChxboxes);
            panel1.Controls.Add(rb_PercentPlus);
            panel1.Controls.Add(rb_PercentMinus);
            panel1.Controls.Add(lbl_percentv);
            panel1.Controls.Add(nud_percent);
            panel1.Controls.Add(lbl_Percent);
            panel1.Controls.Add(Btn_FilePath);
            panel1.Controls.Add(Txb_FilePath);
            panel1.Controls.Add(lbl_File);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 342);
            panel1.TabIndex = 0;
            // 
            // btn_Start
            // 
            btn_Start.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Start.Location = new Point(271, 293);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(99, 31);
            btn_Start.TabIndex = 12;
            btn_Start.Text = "Processar";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // chb_ChangeSell
            // 
            chb_ChangeSell.AutoSize = true;
            chb_ChangeSell.Checked = true;
            chb_ChangeSell.CheckState = CheckState.Checked;
            chb_ChangeSell.Location = new Point(124, 185);
            chb_ChangeSell.Name = "chb_ChangeSell";
            chb_ChangeSell.Size = new Size(58, 19);
            chb_ChangeSell.TabIndex = 11;
            chb_ChangeSell.Text = "Venda";
            chb_ChangeSell.UseVisualStyleBackColor = true;
            // 
            // chb_ChangeBuy
            // 
            chb_ChangeBuy.AutoSize = true;
            chb_ChangeBuy.Location = new Point(29, 185);
            chb_ChangeBuy.Name = "chb_ChangeBuy";
            chb_ChangeBuy.Size = new Size(69, 19);
            chb_ChangeBuy.TabIndex = 10;
            chb_ChangeBuy.Text = "Compra";
            chb_ChangeBuy.UseVisualStyleBackColor = true;
            // 
            // lbl_PrecoChxboxes
            // 
            lbl_PrecoChxboxes.AutoSize = true;
            lbl_PrecoChxboxes.Location = new Point(27, 153);
            lbl_PrecoChxboxes.Name = "lbl_PrecoChxboxes";
            lbl_PrecoChxboxes.Size = new Size(91, 15);
            lbl_PrecoChxboxes.TabIndex = 9;
            lbl_PrecoChxboxes.Text = "Preços a Ajustar";
            // 
            // rb_PercentPlus
            // 
            rb_PercentPlus.AutoSize = true;
            rb_PercentPlus.Location = new Point(334, 104);
            rb_PercentPlus.Name = "rb_PercentPlus";
            rb_PercentPlus.Size = new Size(78, 19);
            rb_PercentPlus.TabIndex = 8;
            rb_PercentPlus.Text = "Aumentar";
            rb_PercentPlus.UseVisualStyleBackColor = true;
            // 
            // rb_PercentMinus
            // 
            rb_PercentMinus.AutoSize = true;
            rb_PercentMinus.Checked = true;
            rb_PercentMinus.Location = new Point(234, 104);
            rb_PercentMinus.Name = "rb_PercentMinus";
            rb_PercentMinus.Size = new Size(71, 19);
            rb_PercentMinus.TabIndex = 7;
            rb_PercentMinus.TabStop = true;
            rb_PercentMinus.Text = "Diminuir";
            rb_PercentMinus.UseVisualStyleBackColor = true;
            // 
            // lbl_percentv
            // 
            lbl_percentv.AutoSize = true;
            lbl_percentv.Location = new Point(154, 106);
            lbl_percentv.Name = "lbl_percentv";
            lbl_percentv.Size = new Size(17, 15);
            lbl_percentv.TabIndex = 6;
            lbl_percentv.Text = "%";
            // 
            // nud_percent
            // 
            nud_percent.Location = new Point(28, 104);
            nud_percent.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nud_percent.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_percent.Name = "nud_percent";
            nud_percent.Size = new Size(120, 23);
            nud_percent.TabIndex = 5;
            nud_percent.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // lbl_Percent
            // 
            lbl_Percent.AutoSize = true;
            lbl_Percent.Location = new Point(23, 79);
            lbl_Percent.Name = "lbl_Percent";
            lbl_Percent.Size = new Size(131, 15);
            lbl_Percent.TabIndex = 4;
            lbl_Percent.Text = "Porcentagem do Ajuste";
            // 
            // Btn_FilePath
            // 
            Btn_FilePath.BackgroundImage = Properties.Resources.folder_icon;
            Btn_FilePath.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_FilePath.Location = new Point(617, 34);
            Btn_FilePath.Name = "Btn_FilePath";
            Btn_FilePath.Size = new Size(27, 27);
            Btn_FilePath.TabIndex = 3;
            Btn_FilePath.UseVisualStyleBackColor = true;
            Btn_FilePath.Click += Btn_FilePath_Click;
            // 
            // Txb_FilePath
            // 
            Txb_FilePath.Location = new Point(19, 37);
            Txb_FilePath.Name = "Txb_FilePath";
            Txb_FilePath.ReadOnly = true;
            Txb_FilePath.Size = new Size(592, 23);
            Txb_FilePath.TabIndex = 2;
            // 
            // lbl_File
            // 
            lbl_File.AutoSize = true;
            lbl_File.Location = new Point(19, 19);
            lbl_File.Name = "lbl_File";
            lbl_File.Size = new Size(93, 15);
            lbl_File.TabIndex = 0;
            lbl_File.Text = "Arquivo de Itens";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 366);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Main";
            Text = "Ragnarok Itens Price Tool";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_percent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_File;
        private TextBox Txb_FilePath;
        private Button Btn_FilePath;
        private Label lbl_Percent;
        private NumericUpDown nud_percent;
        private Label lbl_percentv;
        private RadioButton rb_PercentMinus;
        private RadioButton rb_PercentPlus;
        private Label lbl_PrecoChxboxes;
        private CheckBox chb_ChangeBuy;
        private CheckBox chb_ChangeSell;
        private Button btn_Start;
    }
}
