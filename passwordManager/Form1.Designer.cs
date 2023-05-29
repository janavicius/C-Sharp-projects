
namespace passwordManager
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GradientColorPickerItem gradientColorPickerItem13 = new System.Windows.Forms.GradientColorPickerItem();
            System.Windows.Forms.GradientColorPickerItem gradientColorPickerItem14 = new System.Windows.Forms.GradientColorPickerItem();
            System.Windows.Forms.GradientColorPickerItem gradientColorPickerItem15 = new System.Windows.Forms.GradientColorPickerItem();
            System.Windows.Forms.GradientColorPickerItem gradientColorPickerItem16 = new System.Windows.Forms.GradientColorPickerItem();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.StoreButton = new System.Windows.Forms.Button();
            this.RetrieveButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DisplayAllButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.btnRodyti = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnDidint = new System.Windows.Forms.Button();
            this.btnMazint = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.KeyTextBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gradientColorPicker1 = new System.Windows.Forms.GradientColorPicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.Location = new System.Drawing.Point(666, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "-";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(698, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "✖";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.BackColor = System.Drawing.Color.White;
            this.KeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyTextBox.Location = new System.Drawing.Point(126, 55);
            this.KeyTextBox.Multiline = true;
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(126, 33);
            this.KeyTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(126, 92);
            this.PasswordTextBox.Multiline = true;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(126, 33);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // StoreButton
            // 
            this.StoreButton.BackColor = System.Drawing.Color.Thistle;
            this.StoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoreButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StoreButton.Location = new System.Drawing.Point(126, 131);
            this.StoreButton.Name = "StoreButton";
            this.StoreButton.Size = new System.Drawing.Size(126, 33);
            this.StoreButton.TabIndex = 3;
            this.StoreButton.Text = "Išsaugoti";
            this.StoreButton.UseVisualStyleBackColor = false;
            this.StoreButton.Click += new System.EventHandler(this.StoreButton_Click);
            // 
            // RetrieveButton
            // 
            this.RetrieveButton.BackColor = System.Drawing.Color.Thistle;
            this.RetrieveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RetrieveButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetrieveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RetrieveButton.Location = new System.Drawing.Point(258, 131);
            this.RetrieveButton.Name = "RetrieveButton";
            this.RetrieveButton.Size = new System.Drawing.Size(126, 33);
            this.RetrieveButton.TabIndex = 4;
            this.RetrieveButton.Text = "Gauti";
            this.RetrieveButton.UseVisualStyleBackColor = false;
            this.RetrieveButton.Click += new System.EventHandler(this.RetrieveButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Thistle;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateButton.Location = new System.Drawing.Point(126, 170);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(126, 33);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Atnaujinti";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.Color.Thistle;
            this.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GenerateButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GenerateButton.Location = new System.Drawing.Point(317, 92);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(67, 33);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generuoti";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click_1);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Thistle;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteButton.Location = new System.Drawing.Point(258, 170);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(126, 33);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Pašalinti";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // DisplayAllButton
            // 
            this.DisplayAllButton.BackColor = System.Drawing.Color.Thistle;
            this.DisplayAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayAllButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayAllButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DisplayAllButton.Location = new System.Drawing.Point(405, 59);
            this.DisplayAllButton.Name = "DisplayAllButton";
            this.DisplayAllButton.Size = new System.Drawing.Size(121, 33);
            this.DisplayAllButton.TabIndex = 8;
            this.DisplayAllButton.Text = "Rodyti viską";
            this.DisplayAllButton.UseVisualStyleBackColor = false;
            this.DisplayAllButton.Click += new System.EventHandler(this.DisplayAllButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Raktas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Slaptažodis:";
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.BackColor = System.Drawing.Color.White;
            this.DisplayTextBox.Location = new System.Drawing.Point(405, 98);
            this.DisplayTextBox.Multiline = true;
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.Size = new System.Drawing.Size(319, 194);
            this.DisplayTextBox.TabIndex = 11;
            // 
            // btnRodyti
            // 
            this.btnRodyti.BackColor = System.Drawing.Color.Thistle;
            this.btnRodyti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRodyti.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRodyti.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRodyti.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRodyti.Location = new System.Drawing.Point(259, 91);
            this.btnRodyti.Name = "btnRodyti";
            this.btnRodyti.Size = new System.Drawing.Size(52, 33);
            this.btnRodyti.TabIndex = 12;
            this.btnRodyti.Text = "Rodyti";
            this.btnRodyti.UseVisualStyleBackColor = false;
            this.btnRodyti.Click += new System.EventHandler(this.btnRodyti_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Thistle;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHide.Location = new System.Drawing.Point(532, 59);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(117, 33);
            this.btnHide.TabIndex = 13;
            this.btnHide.Text = "Slėpti";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnDidint
            // 
            this.btnDidint.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDidint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDidint.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDidint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDidint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDidint.Location = new System.Drawing.Point(655, 59);
            this.btnDidint.Name = "btnDidint";
            this.btnDidint.Size = new System.Drawing.Size(33, 33);
            this.btnDidint.TabIndex = 14;
            this.btnDidint.Text = "+";
            this.btnDidint.UseVisualStyleBackColor = false;
            this.btnDidint.Click += new System.EventHandler(this.btnDidint_Click);
            // 
            // btnMazint
            // 
            this.btnMazint.BackColor = System.Drawing.Color.Red;
            this.btnMazint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMazint.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMazint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMazint.Location = new System.Drawing.Point(691, 59);
            this.btnMazint.Name = "btnMazint";
            this.btnMazint.Size = new System.Drawing.Size(33, 33);
            this.btnMazint.TabIndex = 15;
            this.btnMazint.Text = "-";
            this.btnMazint.UseVisualStyleBackColor = false;
            this.btnMazint.Click += new System.EventHandler(this.btnMazint_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Raktas:";
            // 
            // KeyTextBox2
            // 
            this.KeyTextBox2.BackColor = System.Drawing.Color.White;
            this.KeyTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyTextBox2.Location = new System.Drawing.Point(126, 247);
            this.KeyTextBox2.Multiline = true;
            this.KeyTextBox2.Name = "KeyTextBox2";
            this.KeyTextBox2.Size = new System.Drawing.Size(126, 33);
            this.KeyTextBox2.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(393, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 302);
            this.panel2.TabIndex = 18;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Thistle;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExport.Location = new System.Drawing.Point(258, 247);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(126, 33);
            this.btnExport.TabIndex = 19;
            this.btnExport.Text = "Įrašyti...";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(730, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 302);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 302);
            this.panel4.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(1, 300);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(732, 3);
            this.panel5.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(1, 39);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(732, 3);
            this.panel6.TabIndex = 22;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.SteelBlue;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Location = new System.Drawing.Point(1, 223);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(395, 3);
            this.panel10.TabIndex = 23;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gradientColorPicker1
            // 
            this.gradientColorPicker1.AllowAddColorByClick = false;
            this.gradientColorPicker1.AllowColorDialog = false;
            this.gradientColorPicker1.AllowDragOutColor = false;
            this.gradientColorPicker1.AllowPickGradientColor = false;
            this.gradientColorPicker1.AllowToHandleKeys = false;
            this.gradientColorPicker1.AllowToHandleMouseWheel = false;
            this.gradientColorPicker1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.gradientColorPicker1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.gradientColorPicker1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gradientColorPicker1.BackColor = System.Drawing.Color.White;
            this.gradientColorPicker1.ColorItemArrowSize = 0F;
            this.gradientColorPicker1.ColorItemBlockSize = 0F;
            this.gradientColorPicker1.ColorItemWidth = 1;
            gradientColorPickerItem13.Color = System.Drawing.Color.DarkSlateBlue;
            gradientColorPickerItem13.Position = 0F;
            gradientColorPickerItem14.Color = System.Drawing.Color.DarkSlateBlue;
            gradientColorPickerItem14.Position = 0.18F;
            gradientColorPickerItem15.Color = System.Drawing.Color.Indigo;
            gradientColorPickerItem15.Position = 0.5F;
            gradientColorPickerItem16.Position = 0.8F;
            this.gradientColorPicker1.Colors.Add(gradientColorPickerItem13);
            this.gradientColorPicker1.Colors.Add(gradientColorPickerItem14);
            this.gradientColorPicker1.Colors.Add(gradientColorPickerItem15);
            this.gradientColorPicker1.Colors.Add(gradientColorPickerItem16);
            this.gradientColorPicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gradientColorPicker1.GradientLayout = System.Windows.Forms.GradientColorPickerLayout.Background;
            this.gradientColorPicker1.GradientLayoutSize = 15;
            this.gradientColorPicker1.Location = new System.Drawing.Point(-1, -9);
            this.gradientColorPicker1.Name = "gradientColorPicker1";
            this.gradientColorPicker1.SelectedColor = null;
            this.gradientColorPicker1.Size = new System.Drawing.Size(749, 324);
            this.gradientColorPicker1.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 3);
            this.panel1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(734, 304);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KeyTextBox2);
            this.Controls.Add(this.btnMazint);
            this.Controls.Add(this.btnDidint);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnRodyti);
            this.Controls.Add(this.DisplayTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayAllButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.RetrieveButton);
            this.Controls.Add(this.StoreButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.gradientColorPicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button StoreButton;
        private System.Windows.Forms.Button RetrieveButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button DisplayAllButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DisplayTextBox;
        private System.Windows.Forms.Button btnRodyti;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnDidint;
        private System.Windows.Forms.Button btnMazint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox KeyTextBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.GradientColorPicker gradientColorPicker1;
        private System.Windows.Forms.Panel panel1;
    }
}

