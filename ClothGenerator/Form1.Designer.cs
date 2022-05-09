namespace ClothGenerator
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
            this.CodeTextBox = new System.Windows.Forms.RichTextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.LayerCombo = new System.Windows.Forms.ComboBox();
            this.IsDwarfCheck = new System.Windows.Forms.CheckBox();
            this.HumanTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DwarfTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.itemNameTb = new System.Windows.Forms.TextBox();
            this.NamespaceCB = new System.Windows.Forms.CheckBox();
            this.ArmorCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Location = new System.Drawing.Point(13, 25);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(360, 396);
            this.CodeTextBox.TabIndex = 0;
            this.CodeTextBox.Text = "";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(394, 46);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(121, 23);
            this.NameTB.TabIndex = 1;
            // 
            // LayerCombo
            // 
            this.LayerCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LayerCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LayerCombo.FormattingEnabled = true;
            this.LayerCombo.Location = new System.Drawing.Point(394, 98);
            this.LayerCombo.Name = "LayerCombo";
            this.LayerCombo.Size = new System.Drawing.Size(121, 23);
            this.LayerCombo.TabIndex = 2;
            // 
            // IsDwarfCheck
            // 
            this.IsDwarfCheck.AutoSize = true;
            this.IsDwarfCheck.Location = new System.Drawing.Point(394, 173);
            this.IsDwarfCheck.Name = "IsDwarfCheck";
            this.IsDwarfCheck.Size = new System.Drawing.Size(83, 19);
            this.IsDwarfCheck.TabIndex = 3;
            this.IsDwarfCheck.Text = "Nanizzato?";
            this.IsDwarfCheck.UseVisualStyleBackColor = true;
            this.IsDwarfCheck.CheckedChanged += new System.EventHandler(this.IsDwarfCheck_CheckedChanged);
            // 
            // HumanTb
            // 
            this.HumanTb.Location = new System.Drawing.Point(394, 144);
            this.HumanTb.Name = "HumanTb";
            this.HumanTb.Size = new System.Drawing.Size(121, 23);
            this.HumanTb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Layer";
            // 
            // DwarfTb
            // 
            this.DwarfTb.Location = new System.Drawing.Point(394, 198);
            this.DwarfTb.Name = "DwarfTb";
            this.DwarfTb.Size = new System.Drawing.Size(121, 23);
            this.DwarfTb.TabIndex = 7;
            this.DwarfTb.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "ItemId";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(393, 247);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 9;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Item Name";
            // 
            // itemNameTb
            // 
            this.itemNameTb.Location = new System.Drawing.Point(537, 46);
            this.itemNameTb.Name = "itemNameTb";
            this.itemNameTb.Size = new System.Drawing.Size(121, 23);
            this.itemNameTb.TabIndex = 10;
            // 
            // NamespaceCB
            // 
            this.NamespaceCB.AutoSize = true;
            this.NamespaceCB.Location = new System.Drawing.Point(542, 102);
            this.NamespaceCB.Name = "NamespaceCB";
            this.NamespaceCB.Size = new System.Drawing.Size(93, 19);
            this.NamespaceCB.TabIndex = 12;
            this.NamespaceCB.Text = "Namespace?";
            this.NamespaceCB.UseVisualStyleBackColor = true;
            // 
            // ArmorCheck
            // 
            this.ArmorCheck.AutoSize = true;
            this.ArmorCheck.Location = new System.Drawing.Point(542, 146);
            this.ArmorCheck.Name = "ArmorCheck";
            this.ArmorCheck.Size = new System.Drawing.Size(65, 19);
            this.ArmorCheck.TabIndex = 13;
            this.ArmorCheck.Text = "Armor?";
            this.ArmorCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ArmorCheck);
            this.Controls.Add(this.NamespaceCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itemNameTb);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DwarfTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HumanTb);
            this.Controls.Add(this.IsDwarfCheck);
            this.Controls.Add(this.LayerCombo);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.CodeTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox CodeTextBox;
        private TextBox NameTB;
        private ComboBox LayerCombo;
        private CheckBox IsDwarfCheck;
        private TextBox HumanTb;
        private Label label1;
        private Label label2;
        private TextBox DwarfTb;
        private Label label3;
        private Button GenerateButton;
        private Label label4;
        private TextBox itemNameTb;
        private CheckBox NamespaceCB;
        private CheckBox ArmorCheck;
    }
}