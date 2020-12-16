namespace _3DModel
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
            this.Screen = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TurnDown = new System.Windows.Forms.Button();
            this.TurnRight = new System.Windows.Forms.Button();
            this.TurnLeft = new System.Windows.Forms.Button();
            this.TurnUp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Decrease = new System.Windows.Forms.Button();
            this.Enlarge = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TransitionDown = new System.Windows.Forms.Button();
            this.TransitionRight = new System.Windows.Forms.Button();
            this.TransitionLeft = new System.Windows.Forms.Button();
            this.TransitionUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Screen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.Location = new System.Drawing.Point(12, 12);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(801, 608);
            this.Screen.TabIndex = 0;
            this.Screen.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TurnDown);
            this.groupBox1.Controls.Add(this.TurnRight);
            this.groupBox1.Controls.Add(this.TurnLeft);
            this.groupBox1.Controls.Add(this.TurnUp);
            this.groupBox1.Location = new System.Drawing.Point(819, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поворот";
            // 
            // TurnDown
            // 
            this.TurnDown.Location = new System.Drawing.Point(44, 71);
            this.TurnDown.Name = "TurnDown";
            this.TurnDown.Size = new System.Drawing.Size(50, 23);
            this.TurnDown.TabIndex = 0;
            this.TurnDown.Text = "down";
            this.TurnDown.UseVisualStyleBackColor = true;
            this.TurnDown.Click += new System.EventHandler(this.TurnDown_Click);
            // 
            // TurnRight
            // 
            this.TurnRight.Location = new System.Drawing.Point(93, 48);
            this.TurnRight.Name = "TurnRight";
            this.TurnRight.Size = new System.Drawing.Size(43, 23);
            this.TurnRight.TabIndex = 0;
            this.TurnRight.Text = "right";
            this.TurnRight.UseVisualStyleBackColor = true;
            this.TurnRight.Click += new System.EventHandler(this.TurnRight_Click);
            // 
            // TurnLeft
            // 
            this.TurnLeft.Location = new System.Drawing.Point(2, 48);
            this.TurnLeft.Name = "TurnLeft";
            this.TurnLeft.Size = new System.Drawing.Size(43, 23);
            this.TurnLeft.TabIndex = 0;
            this.TurnLeft.Text = "left";
            this.TurnLeft.UseVisualStyleBackColor = true;
            this.TurnLeft.Click += new System.EventHandler(this.TurnLeft_Click);
            // 
            // TurnUp
            // 
            this.TurnUp.Location = new System.Drawing.Point(44, 22);
            this.TurnUp.Name = "TurnUp";
            this.TurnUp.Size = new System.Drawing.Size(50, 23);
            this.TurnUp.TabIndex = 0;
            this.TurnUp.Text = "up";
            this.TurnUp.UseVisualStyleBackColor = true;
            this.TurnUp.Click += new System.EventHandler(this.TurnUp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Decrease);
            this.groupBox2.Controls.Add(this.Enlarge);
            this.groupBox2.Location = new System.Drawing.Point(819, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Приближение";
            // 
            // Decrease
            // 
            this.Decrease.Location = new System.Drawing.Point(44, 71);
            this.Decrease.Name = "Decrease";
            this.Decrease.Size = new System.Drawing.Size(66, 23);
            this.Decrease.TabIndex = 0;
            this.Decrease.Text = "decrease";
            this.Decrease.UseVisualStyleBackColor = true;
            this.Decrease.Click += new System.EventHandler(this.Decrease_Click);
            // 
            // Enlarge
            // 
            this.Enlarge.Location = new System.Drawing.Point(44, 22);
            this.Enlarge.Name = "Enlarge";
            this.Enlarge.Size = new System.Drawing.Size(66, 23);
            this.Enlarge.TabIndex = 0;
            this.Enlarge.Text = "enlarge";
            this.Enlarge.UseVisualStyleBackColor = true;
            this.Enlarge.Click += new System.EventHandler(this.Enlarge_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TransitionDown);
            this.groupBox3.Controls.Add(this.TransitionRight);
            this.groupBox3.Controls.Add(this.TransitionLeft);
            this.groupBox3.Controls.Add(this.TransitionUp);
            this.groupBox3.Location = new System.Drawing.Point(819, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Перемещние";
            // 
            // TransitionDown
            // 
            this.TransitionDown.Location = new System.Drawing.Point(44, 71);
            this.TransitionDown.Name = "TransitionDown";
            this.TransitionDown.Size = new System.Drawing.Size(50, 23);
            this.TransitionDown.TabIndex = 0;
            this.TransitionDown.Text = "down";
            this.TransitionDown.UseVisualStyleBackColor = true;
            this.TransitionDown.Click += new System.EventHandler(this.TransitionDown_Click);
            // 
            // TransitionRight
            // 
            this.TransitionRight.Location = new System.Drawing.Point(93, 48);
            this.TransitionRight.Name = "TransitionRight";
            this.TransitionRight.Size = new System.Drawing.Size(43, 23);
            this.TransitionRight.TabIndex = 0;
            this.TransitionRight.Text = "right";
            this.TransitionRight.UseVisualStyleBackColor = true;
            this.TransitionRight.Click += new System.EventHandler(this.TransitionRight_Click);
            // 
            // TransitionLeft
            // 
            this.TransitionLeft.Location = new System.Drawing.Point(2, 48);
            this.TransitionLeft.Name = "TransitionLeft";
            this.TransitionLeft.Size = new System.Drawing.Size(43, 23);
            this.TransitionLeft.TabIndex = 0;
            this.TransitionLeft.Text = "left";
            this.TransitionLeft.UseVisualStyleBackColor = true;
            this.TransitionLeft.Click += new System.EventHandler(this.TransitionLeft_Click);
            // 
            // TransitionUp
            // 
            this.TransitionUp.Location = new System.Drawing.Point(44, 22);
            this.TransitionUp.Name = "TransitionUp";
            this.TransitionUp.Size = new System.Drawing.Size(50, 23);
            this.TransitionUp.TabIndex = 0;
            this.TransitionUp.Text = "up";
            this.TransitionUp.UseVisualStyleBackColor = true;
            this.TransitionUp.Click += new System.EventHandler(this.TransitionUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 632);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Screen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Screen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Screen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button TurnDown;
        private System.Windows.Forms.Button TurnRight;
        private System.Windows.Forms.Button TurnLeft;
        private System.Windows.Forms.Button TurnUp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Decrease;
        private System.Windows.Forms.Button Enlarge;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button TransitionDown;
        private System.Windows.Forms.Button TransitionRight;
        private System.Windows.Forms.Button TransitionLeft;
        private System.Windows.Forms.Button TransitionUp;
    }
}

