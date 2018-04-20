namespace RubyWindows
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
            this.txtrow = new System.Windows.Forms.TextBox();
            this.txtcol = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.C_wall = new System.Windows.Forms.Button();
            this.wall = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.AC = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panelBtns = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtrow
            // 
            this.txtrow.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrow.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtrow.Location = new System.Drawing.Point(42, 41);
            this.txtrow.Name = "txtrow";
            this.txtrow.Size = new System.Drawing.Size(63, 20);
            this.txtrow.TabIndex = 1;
            // 
            // txtcol
            // 
            this.txtcol.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtcol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcol.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtcol.Location = new System.Drawing.Point(43, 15);
            this.txtcol.Name = "txtcol";
            this.txtcol.Size = new System.Drawing.Size(63, 23);
            this.txtcol.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Matrix";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(112, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "0:20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(112, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "0:35";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(24, 136);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(82, 31);
            this.start.TabIndex = 3;
            this.start.Text = "S";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // C_wall
            // 
            this.C_wall.BackColor = System.Drawing.Color.White;
            this.C_wall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C_wall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_wall.ForeColor = System.Drawing.Color.Maroon;
            this.C_wall.Location = new System.Drawing.Point(24, 247);
            this.C_wall.Name = "C_wall";
            this.C_wall.Size = new System.Drawing.Size(81, 29);
            this.C_wall.TabIndex = 6;
            this.C_wall.Text = "Clear Cell";
            this.C_wall.UseVisualStyleBackColor = false;
            this.C_wall.Click += new System.EventHandler(this.C_wall_Click);
            // 
            // wall
            // 
            this.wall.BackColor = System.Drawing.Color.Sienna;
            this.wall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wall.ForeColor = System.Drawing.Color.White;
            this.wall.Location = new System.Drawing.Point(25, 210);
            this.wall.Name = "wall";
            this.wall.Size = new System.Drawing.Size(80, 31);
            this.wall.TabIndex = 5;
            this.wall.Text = "Wall";
            this.wall.UseVisualStyleBackColor = false;
            this.wall.Click += new System.EventHandler(this.wall_Click);
            // 
            // end
            // 
            this.end.BackColor = System.Drawing.Color.Red;
            this.end.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.Location = new System.Drawing.Point(25, 173);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(80, 31);
            this.end.TabIndex = 4;
            this.end.Text = "E";
            this.end.UseVisualStyleBackColor = false;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // AC
            // 
            this.AC.BackColor = System.Drawing.Color.PowderBlue;
            this.AC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AC.ForeColor = System.Drawing.Color.Indigo;
            this.AC.Location = new System.Drawing.Point(25, 282);
            this.AC.Name = "AC";
            this.AC.Size = new System.Drawing.Size(81, 30);
            this.AC.TabIndex = 8;
            this.AC.Text = "Clear All";
            this.AC.UseVisualStyleBackColor = false;
            this.AC.Click += new System.EventHandler(this.AC_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Blue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(24, 368);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 72);
            this.button7.TabIndex = 7;
            this.button7.Text = "Go";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panelBtns
            // 
            this.panelBtns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBtns.AutoScroll = true;
            this.panelBtns.BackColor = System.Drawing.Color.DarkGreen;
            this.panelBtns.Location = new System.Drawing.Point(163, 34);
            this.panelBtns.Name = "panelBtns";
            this.panelBtns.Size = new System.Drawing.Size(1055, 587);
            this.panelBtns.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(16, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 54);
            this.label5.TabIndex = 15;
            this.label5.Text = "Path ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(176, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Row : Col";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(5, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Row";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(5, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Col";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtcol);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtrow);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.C_wall);
            this.panel1.Controls.Add(this.wall);
            this.panel1.Controls.Add(this.end);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.AC);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 587);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PowderBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Indigo;
            this.button2.Location = new System.Drawing.Point(25, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 30);
            this.button2.TabIndex = 19;
            this.button2.Text = "Clear Path";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1243, 633);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelBtns);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ruby Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtrow;
        private System.Windows.Forms.TextBox txtcol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button C_wall;
        private System.Windows.Forms.Button wall;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.Button AC;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panelBtns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}

