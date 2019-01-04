namespace BPowersAssignment1
{
    partial class Design
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Design));
            this.generateButton = new System.Windows.Forms.Button();
            this.rowTxtBox = new System.Windows.Forms.TextBox();
            this.columnTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yellowBoxButton = new System.Windows.Forms.Button();
            this.blueBoxButton = new System.Windows.Forms.Button();
            this.greenBoxButton = new System.Windows.Forms.Button();
            this.redBoxButton = new System.Windows.Forms.Button();
            this.yellowDoorButton = new System.Windows.Forms.Button();
            this.blueDoorButton = new System.Windows.Forms.Button();
            this.greenDoorButton = new System.Windows.Forms.Button();
            this.redDoorButton = new System.Windows.Forms.Button();
            this.wallButton = new System.Windows.Forms.Button();
            this.noneButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(319, 34);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(85, 33);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate Grid";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // rowTxtBox
            // 
            this.rowTxtBox.Location = new System.Drawing.Point(36, 43);
            this.rowTxtBox.Name = "rowTxtBox";
            this.rowTxtBox.Size = new System.Drawing.Size(85, 20);
            this.rowTxtBox.TabIndex = 1;
            // 
            // columnTxtBox
            // 
            this.columnTxtBox.Location = new System.Drawing.Point(167, 43);
            this.columnTxtBox.Name = "columnTxtBox";
            this.columnTxtBox.Size = new System.Drawing.Size(85, 20);
            this.columnTxtBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Columns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rows";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 72);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.yellowBoxButton);
            this.groupBox2.Controls.Add(this.blueBoxButton);
            this.groupBox2.Controls.Add(this.greenBoxButton);
            this.groupBox2.Controls.Add(this.redBoxButton);
            this.groupBox2.Controls.Add(this.yellowDoorButton);
            this.groupBox2.Controls.Add(this.blueDoorButton);
            this.groupBox2.Controls.Add(this.greenDoorButton);
            this.groupBox2.Controls.Add(this.redDoorButton);
            this.groupBox2.Controls.Add(this.wallButton);
            this.groupBox2.Controls.Add(this.noneButton);
            this.groupBox2.Location = new System.Drawing.Point(10, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 596);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // yellowBoxButton
            // 
            this.yellowBoxButton.Image = ((System.Drawing.Image)(resources.GetObject("yellowBoxButton.Image")));
            this.yellowBoxButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yellowBoxButton.Location = new System.Drawing.Point(7, 497);
            this.yellowBoxButton.Name = "yellowBoxButton";
            this.yellowBoxButton.Size = new System.Drawing.Size(138, 48);
            this.yellowBoxButton.TabIndex = 14;
            this.yellowBoxButton.Text = "Yellow Box";
            this.yellowBoxButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.yellowBoxButton.UseVisualStyleBackColor = true;
            this.yellowBoxButton.Click += new System.EventHandler(this.yellowBoxButton_Click);
            // 
            // blueBoxButton
            // 
            this.blueBoxButton.Image = ((System.Drawing.Image)(resources.GetObject("blueBoxButton.Image")));
            this.blueBoxButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.blueBoxButton.Location = new System.Drawing.Point(7, 443);
            this.blueBoxButton.Name = "blueBoxButton";
            this.blueBoxButton.Size = new System.Drawing.Size(138, 48);
            this.blueBoxButton.TabIndex = 13;
            this.blueBoxButton.Text = "Blue Box";
            this.blueBoxButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.blueBoxButton.UseVisualStyleBackColor = true;
            this.blueBoxButton.Click += new System.EventHandler(this.blueBoxButton_Click);
            // 
            // greenBoxButton
            // 
            this.greenBoxButton.Image = ((System.Drawing.Image)(resources.GetObject("greenBoxButton.Image")));
            this.greenBoxButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.greenBoxButton.Location = new System.Drawing.Point(6, 389);
            this.greenBoxButton.Name = "greenBoxButton";
            this.greenBoxButton.Size = new System.Drawing.Size(138, 48);
            this.greenBoxButton.TabIndex = 12;
            this.greenBoxButton.Text = "Green Box";
            this.greenBoxButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.greenBoxButton.UseVisualStyleBackColor = true;
            this.greenBoxButton.Click += new System.EventHandler(this.greenBoxButton_Click);
            // 
            // redBoxButton
            // 
            this.redBoxButton.Image = ((System.Drawing.Image)(resources.GetObject("redBoxButton.Image")));
            this.redBoxButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.redBoxButton.Location = new System.Drawing.Point(6, 335);
            this.redBoxButton.Name = "redBoxButton";
            this.redBoxButton.Size = new System.Drawing.Size(138, 48);
            this.redBoxButton.TabIndex = 11;
            this.redBoxButton.Text = "Red Box";
            this.redBoxButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.redBoxButton.UseVisualStyleBackColor = true;
            this.redBoxButton.Click += new System.EventHandler(this.redBoxButton_Click);
            // 
            // yellowDoorButton
            // 
            this.yellowDoorButton.Image = ((System.Drawing.Image)(resources.GetObject("yellowDoorButton.Image")));
            this.yellowDoorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yellowDoorButton.Location = new System.Drawing.Point(6, 281);
            this.yellowDoorButton.Name = "yellowDoorButton";
            this.yellowDoorButton.Size = new System.Drawing.Size(138, 48);
            this.yellowDoorButton.TabIndex = 10;
            this.yellowDoorButton.Text = "Yellow Door";
            this.yellowDoorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.yellowDoorButton.UseVisualStyleBackColor = true;
            this.yellowDoorButton.Click += new System.EventHandler(this.yellowDoorButton_Click);
            // 
            // blueDoorButton
            // 
            this.blueDoorButton.Image = ((System.Drawing.Image)(resources.GetObject("blueDoorButton.Image")));
            this.blueDoorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.blueDoorButton.Location = new System.Drawing.Point(7, 227);
            this.blueDoorButton.Name = "blueDoorButton";
            this.blueDoorButton.Size = new System.Drawing.Size(138, 48);
            this.blueDoorButton.TabIndex = 9;
            this.blueDoorButton.Text = "Blue Door";
            this.blueDoorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.blueDoorButton.UseVisualStyleBackColor = true;
            this.blueDoorButton.Click += new System.EventHandler(this.blueDoorButton_Click);
            // 
            // greenDoorButton
            // 
            this.greenDoorButton.Image = ((System.Drawing.Image)(resources.GetObject("greenDoorButton.Image")));
            this.greenDoorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.greenDoorButton.Location = new System.Drawing.Point(7, 173);
            this.greenDoorButton.Name = "greenDoorButton";
            this.greenDoorButton.Size = new System.Drawing.Size(138, 48);
            this.greenDoorButton.TabIndex = 8;
            this.greenDoorButton.Text = "Green Door";
            this.greenDoorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.greenDoorButton.UseVisualStyleBackColor = true;
            this.greenDoorButton.Click += new System.EventHandler(this.greenDoorButton_Click);
            // 
            // redDoorButton
            // 
            this.redDoorButton.Image = ((System.Drawing.Image)(resources.GetObject("redDoorButton.Image")));
            this.redDoorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.redDoorButton.Location = new System.Drawing.Point(7, 119);
            this.redDoorButton.Name = "redDoorButton";
            this.redDoorButton.Size = new System.Drawing.Size(138, 48);
            this.redDoorButton.TabIndex = 7;
            this.redDoorButton.Text = "Red Door";
            this.redDoorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.redDoorButton.UseVisualStyleBackColor = true;
            this.redDoorButton.Click += new System.EventHandler(this.redDoorButton_Click);
            // 
            // wallButton
            // 
            this.wallButton.Image = ((System.Drawing.Image)(resources.GetObject("wallButton.Image")));
            this.wallButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wallButton.Location = new System.Drawing.Point(7, 65);
            this.wallButton.Name = "wallButton";
            this.wallButton.Size = new System.Drawing.Size(138, 48);
            this.wallButton.TabIndex = 1;
            this.wallButton.Text = "Wall";
            this.wallButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.wallButton.UseVisualStyleBackColor = true;
            this.wallButton.Click += new System.EventHandler(this.wallButton_Click);
            // 
            // noneButton
            // 
            this.noneButton.Image = ((System.Drawing.Image)(resources.GetObject("noneButton.Image")));
            this.noneButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.noneButton.Location = new System.Drawing.Point(7, 11);
            this.noneButton.Name = "noneButton";
            this.noneButton.Size = new System.Drawing.Size(138, 48);
            this.noneButton.TabIndex = 0;
            this.noneButton.Text = "None";
            this.noneButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.noneButton.UseVisualStyleBackColor = true;
            this.noneButton.Click += new System.EventHandler(this.noneButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenu
            // 
            this.fileToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenu.Name = "fileToolStripMenu";
            this.fileToolStripMenu.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenu.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // Design
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 690);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.columnTxtBox);
            this.Controls.Add(this.rowTxtBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Design";
            this.Text = "Design";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox rowTxtBox;
        private System.Windows.Forms.TextBox columnTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button yellowBoxButton;
        private System.Windows.Forms.Button blueBoxButton;
        private System.Windows.Forms.Button greenBoxButton;
        private System.Windows.Forms.Button redBoxButton;
        private System.Windows.Forms.Button yellowDoorButton;
        private System.Windows.Forms.Button blueDoorButton;
        private System.Windows.Forms.Button greenDoorButton;
        private System.Windows.Forms.Button redDoorButton;
        private System.Windows.Forms.Button wallButton;
        private System.Windows.Forms.Button noneButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    }
}