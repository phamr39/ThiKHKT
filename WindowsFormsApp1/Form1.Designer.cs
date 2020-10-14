﻿namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.ClassTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LockCheckbox = new System.Windows.Forms.CheckBox();
            this.SchoolTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FirstTimeBtn = new System.Windows.Forms.RadioButton();
            this.SecondTimeBtn = new System.Windows.Forms.RadioButton();
            this.ThirdTimeBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ThirdTimeResult = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ResultSecondTime = new System.Windows.Forms.Label();
            this.ResultFirstTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ThirtTimeStatus = new System.Windows.Forms.PictureBox();
            this.SecondTimeStatus = new System.Windows.Forms.PictureBox();
            this.FirstTimeStatus = new System.Windows.Forms.PictureBox();
            this.GetDataBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThirtTimeStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondTimeStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstTimeStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần mềm chấm điểm bài thi ném lựu đạn ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên học sinh";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextbox.Location = new System.Drawing.Point(489, 135);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(196, 31);
            this.NameTextbox.TabIndex = 2;
            this.NameTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ClassTextbox
            // 
            this.ClassTextbox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassTextbox.Location = new System.Drawing.Point(489, 98);
            this.ClassTextbox.Name = "ClassTextbox";
            this.ClassTextbox.Size = new System.Drawing.Size(75, 31);
            this.ClassTextbox.TabIndex = 4;
            this.ClassTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lớp";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LockCheckbox
            // 
            this.LockCheckbox.AutoSize = true;
            this.LockCheckbox.Location = new System.Drawing.Point(607, 107);
            this.LockCheckbox.Name = "LockCheckbox";
            this.LockCheckbox.Size = new System.Drawing.Size(51, 17);
            this.LockCheckbox.TabIndex = 5;
            this.LockCheckbox.Text = "Khóa";
            this.LockCheckbox.UseVisualStyleBackColor = true;
            this.LockCheckbox.CheckedChanged += new System.EventHandler(this.LockCheckbox_CheckedChanged);
            // 
            // SchoolTextbox
            // 
            this.SchoolTextbox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchoolTextbox.Location = new System.Drawing.Point(489, 61);
            this.SchoolTextbox.Name = "SchoolTextbox";
            this.SchoolTextbox.Size = new System.Drawing.Size(196, 31);
            this.SchoolTextbox.TabIndex = 7;
            this.SchoolTextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(379, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Trường";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FirstTimeBtn
            // 
            this.FirstTimeBtn.AutoSize = true;
            this.FirstTimeBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstTimeBtn.Location = new System.Drawing.Point(74, 30);
            this.FirstTimeBtn.Name = "FirstTimeBtn";
            this.FirstTimeBtn.Size = new System.Drawing.Size(69, 27);
            this.FirstTimeBtn.TabIndex = 10;
            this.FirstTimeBtn.TabStop = true;
            this.FirstTimeBtn.Text = "Lần 1";
            this.FirstTimeBtn.UseVisualStyleBackColor = true;
            // 
            // SecondTimeBtn
            // 
            this.SecondTimeBtn.AutoSize = true;
            this.SecondTimeBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondTimeBtn.Location = new System.Drawing.Point(149, 30);
            this.SecondTimeBtn.Name = "SecondTimeBtn";
            this.SecondTimeBtn.Size = new System.Drawing.Size(69, 27);
            this.SecondTimeBtn.TabIndex = 11;
            this.SecondTimeBtn.TabStop = true;
            this.SecondTimeBtn.Text = "Lần 2";
            this.SecondTimeBtn.UseVisualStyleBackColor = true;
            // 
            // ThirdTimeBtn
            // 
            this.ThirdTimeBtn.AutoSize = true;
            this.ThirdTimeBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdTimeBtn.Location = new System.Drawing.Point(224, 30);
            this.ThirdTimeBtn.Name = "ThirdTimeBtn";
            this.ThirdTimeBtn.Size = new System.Drawing.Size(69, 27);
            this.ThirdTimeBtn.TabIndex = 12;
            this.ThirdTimeBtn.TabStop = true;
            this.ThirdTimeBtn.Text = "Lần 3";
            this.ThirdTimeBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearBtn);
            this.groupBox1.Controls.Add(this.ThirdTimeResult);
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(this.ResultSecondTime);
            this.groupBox1.Controls.Add(this.ResultFirstTime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ThirtTimeStatus);
            this.groupBox1.Controls.Add(this.SecondTimeStatus);
            this.groupBox1.Controls.Add(this.FirstTimeStatus);
            this.groupBox1.Controls.Add(this.SecondTimeBtn);
            this.groupBox1.Controls.Add(this.ThirdTimeBtn);
            this.groupBox1.Controls.Add(this.FirstTimeBtn);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(383, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 214);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lần thi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(60, 160);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 37);
            this.ClearBtn.TabIndex = 15;
            this.ClearBtn.Text = "Xóa";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ThirdTimeResult
            // 
            this.ThirdTimeResult.AutoSize = true;
            this.ThirdTimeResult.Location = new System.Drawing.Point(229, 113);
            this.ThirdTimeResult.Name = "ThirdTimeResult";
            this.ThirdTimeResult.Size = new System.Drawing.Size(54, 23);
            this.ThirdTimeResult.TabIndex = 19;
            this.ThirdTimeResult.Text = "2.0 m";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(183, 160);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 37);
            this.SaveBtn.TabIndex = 14;
            this.SaveBtn.Text = "Lưu";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // ResultSecondTime
            // 
            this.ResultSecondTime.AutoSize = true;
            this.ResultSecondTime.Location = new System.Drawing.Point(154, 113);
            this.ResultSecondTime.Name = "ResultSecondTime";
            this.ResultSecondTime.Size = new System.Drawing.Size(54, 23);
            this.ResultSecondTime.TabIndex = 18;
            this.ResultSecondTime.Text = "2.0 m";
            // 
            // ResultFirstTime
            // 
            this.ResultFirstTime.AutoSize = true;
            this.ResultFirstTime.Location = new System.Drawing.Point(81, 113);
            this.ResultFirstTime.Name = "ResultFirstTime";
            this.ResultFirstTime.Size = new System.Drawing.Size(54, 23);
            this.ResultFirstTime.TabIndex = 17;
            this.ResultFirstTime.Text = "0.1 m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kết quả";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ThirtTimeStatus
            // 
            this.ThirtTimeStatus.Image = ((System.Drawing.Image)(resources.GetObject("ThirtTimeStatus.Image")));
            this.ThirtTimeStatus.InitialImage = null;
            this.ThirtTimeStatus.Location = new System.Drawing.Point(242, 78);
            this.ThirtTimeStatus.Name = "ThirtTimeStatus";
            this.ThirtTimeStatus.Size = new System.Drawing.Size(32, 32);
            this.ThirtTimeStatus.TabIndex = 15;
            this.ThirtTimeStatus.TabStop = false;
            // 
            // SecondTimeStatus
            // 
            this.SecondTimeStatus.Image = ((System.Drawing.Image)(resources.GetObject("SecondTimeStatus.Image")));
            this.SecondTimeStatus.InitialImage = null;
            this.SecondTimeStatus.Location = new System.Drawing.Point(167, 78);
            this.SecondTimeStatus.Name = "SecondTimeStatus";
            this.SecondTimeStatus.Size = new System.Drawing.Size(32, 32);
            this.SecondTimeStatus.TabIndex = 14;
            this.SecondTimeStatus.TabStop = false;
            // 
            // FirstTimeStatus
            // 
            this.FirstTimeStatus.Image = ((System.Drawing.Image)(resources.GetObject("FirstTimeStatus.Image")));
            this.FirstTimeStatus.InitialImage = null;
            this.FirstTimeStatus.Location = new System.Drawing.Point(94, 78);
            this.FirstTimeStatus.Name = "FirstTimeStatus";
            this.FirstTimeStatus.Size = new System.Drawing.Size(32, 32);
            this.FirstTimeStatus.TabIndex = 13;
            this.FirstTimeStatus.TabStop = false;
            // 
            // GetDataBtn
            // 
            this.GetDataBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetDataBtn.Location = new System.Drawing.Point(111, 412);
            this.GetDataBtn.Name = "GetDataBtn";
            this.GetDataBtn.Size = new System.Drawing.Size(142, 35);
            this.GetDataBtn.TabIndex = 20;
            this.GetDataBtn.Text = "Lấy kết quả";
            this.GetDataBtn.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 458);
            this.Controls.Add(this.GetDataBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SchoolTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LockCheckbox);
            this.Controls.Add(this.ClassTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ClassTextbox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThirtTimeStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondTimeStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstTimeStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox ClassTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox LockCheckbox;
        private System.Windows.Forms.TextBox SchoolTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton FirstTimeBtn;
        private System.Windows.Forms.RadioButton SecondTimeBtn;
        private System.Windows.Forms.RadioButton ThirdTimeBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox ThirtTimeStatus;
        private System.Windows.Forms.PictureBox SecondTimeStatus;
        private System.Windows.Forms.PictureBox FirstTimeStatus;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label ThirdTimeResult;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label ResultSecondTime;
        private System.Windows.Forms.Label ResultFirstTime;
        private System.Windows.Forms.Button GetDataBtn;
        private System.Windows.Forms.Timer timer1;
    }
}

