
namespace Rubicks_Cube
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.yRotateAll = new Rubicks_Cube.RoundButton();
            this.zRotate20 = new Rubicks_Cube.RoundButton();
            this.xRotate00 = new Rubicks_Cube.RoundButton();
            this.xRotate10 = new Rubicks_Cube.RoundButton();
            this.xRotate20 = new Rubicks_Cube.RoundButton();
            this.yRotate21 = new Rubicks_Cube.RoundButton();
            this.yRotate01 = new Rubicks_Cube.RoundButton();
            this.yRotate11 = new Rubicks_Cube.RoundButton();
            this.xRotate11 = new Rubicks_Cube.RoundButton();
            this.xRotate21 = new Rubicks_Cube.RoundButton();
            this.xRotate01 = new Rubicks_Cube.RoundButton();
            this.yRotate00 = new Rubicks_Cube.RoundButton();
            this.yRotate10 = new Rubicks_Cube.RoundButton();
            this.zRotate21 = new Rubicks_Cube.RoundButton();
            this.xRotateAll = new Rubicks_Cube.RoundButton();
            this.zRotateAll = new Rubicks_Cube.RoundButton();
            this.yRotate20 = new Rubicks_Cube.RoundButton();
            this.zRotate10 = new Rubicks_Cube.RoundButton();
            this.zRotate11 = new Rubicks_Cube.RoundButton();
            this.zRotate00 = new Rubicks_Cube.RoundButton();
            this.zRotate01 = new Rubicks_Cube.RoundButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.yRotateAll);
            this.panel1.Controls.Add(this.zRotate20);
            this.panel1.Controls.Add(this.xRotate00);
            this.panel1.Controls.Add(this.xRotate10);
            this.panel1.Controls.Add(this.xRotate20);
            this.panel1.Controls.Add(this.yRotate21);
            this.panel1.Controls.Add(this.yRotate01);
            this.panel1.Controls.Add(this.yRotate11);
            this.panel1.Controls.Add(this.xRotate11);
            this.panel1.Controls.Add(this.xRotate21);
            this.panel1.Controls.Add(this.xRotate01);
            this.panel1.Controls.Add(this.yRotate00);
            this.panel1.Controls.Add(this.yRotate10);
            this.panel1.Controls.Add(this.zRotate21);
            this.panel1.Controls.Add(this.xRotateAll);
            this.panel1.Controls.Add(this.zRotateAll);
            this.panel1.Controls.Add(this.yRotate20);
            this.panel1.Controls.Add(this.zRotate10);
            this.panel1.Controls.Add(this.zRotate11);
            this.panel1.Controls.Add(this.zRotate00);
            this.panel1.Controls.Add(this.zRotate01);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 600);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(627, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 395);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(301, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "By Akbar Abdujalilov";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(579, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(579, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Shuffle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(627, 492);
            this.progressBar1.Minimum = 30;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(507, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 30;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // yRotateAll
            // 
            this.yRotateAll.BackColor = System.Drawing.Color.Transparent;
            this.yRotateAll.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.yRotateAll.FlatAppearance.BorderSize = 0;
            this.yRotateAll.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.yRotateAll.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.yRotateAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yRotateAll.Image = ((System.Drawing.Image)(resources.GetObject("yRotateAll.Image")));
            this.yRotateAll.Location = new System.Drawing.Point(358, 336);
            this.yRotateAll.Name = "yRotateAll";
            this.yRotateAll.Size = new System.Drawing.Size(50, 50);
            this.yRotateAll.TabIndex = 0;
            this.yRotateAll.UseVisualStyleBackColor = false;
            this.yRotateAll.Click += new System.EventHandler(this.yRotateAll_Click);
            // 
            // zRotate20
            // 
            this.zRotate20.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.zRotate20.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.zRotate20.FlatAppearance.BorderSize = 0;
            this.zRotate20.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.zRotate20.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.zRotate20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zRotate20.Image = ((System.Drawing.Image)(resources.GetObject("zRotate20.Image")));
            this.zRotate20.Location = new System.Drawing.Point(497, 349);
            this.zRotate20.Name = "zRotate20";
            this.zRotate20.Size = new System.Drawing.Size(50, 50);
            this.zRotate20.TabIndex = 0;
            this.zRotate20.UseVisualStyleBackColor = false;
            this.zRotate20.Click += new System.EventHandler(this.zRotate20_Click);
            // 
            // xRotate00
            // 
            this.xRotate00.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.xRotate00.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.xRotate00.FlatAppearance.BorderSize = 0;
            this.xRotate00.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.xRotate00.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.xRotate00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xRotate00.Image = ((System.Drawing.Image)(resources.GetObject("xRotate00.Image")));
            this.xRotate00.Location = new System.Drawing.Point(55, 105);
            this.xRotate00.Name = "xRotate00";
            this.xRotate00.Size = new System.Drawing.Size(50, 50);
            this.xRotate00.TabIndex = 0;
            this.xRotate00.UseVisualStyleBackColor = false;
            this.xRotate00.Click += new System.EventHandler(this.xRotate00_Click);
            // 
            // xRotate10
            // 
            this.xRotate10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.xRotate10.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.xRotate10.FlatAppearance.BorderSize = 0;
            this.xRotate10.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.xRotate10.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.xRotate10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xRotate10.Image = ((System.Drawing.Image)(resources.GetObject("xRotate10.Image")));
            this.xRotate10.Location = new System.Drawing.Point(124, 65);
            this.xRotate10.Name = "xRotate10";
            this.xRotate10.Size = new System.Drawing.Size(50, 50);
            this.xRotate10.TabIndex = 0;
            this.xRotate10.UseVisualStyleBackColor = false;
            this.xRotate10.Click += new System.EventHandler(this.xRotate10_Click);
            // 
            // xRotate20
            // 
            this.xRotate20.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.xRotate20.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.xRotate20.FlatAppearance.BorderSize = 0;
            this.xRotate20.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.xRotate20.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.xRotate20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xRotate20.Image = ((System.Drawing.Image)(resources.GetObject("xRotate20.Image")));
            this.xRotate20.Location = new System.Drawing.Point(191, 27);
            this.xRotate20.Name = "xRotate20";
            this.xRotate20.Size = new System.Drawing.Size(50, 50);
            this.xRotate20.TabIndex = 0;
            this.xRotate20.UseVisualStyleBackColor = false;
            this.xRotate20.Click += new System.EventHandler(this.xRotate20_Click);
            // 
            // yRotate21
            // 
            this.yRotate21.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.yRotate21.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.yRotate21.FlatAppearance.BorderSize = 0;
            this.yRotate21.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.yRotate21.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.yRotate21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yRotate21.Image = ((System.Drawing.Image)(resources.GetObject("yRotate21.Image")));
            this.yRotate21.Location = new System.Drawing.Point(307, 27);
            this.yRotate21.Name = "yRotate21";
            this.yRotate21.Size = new System.Drawing.Size(50, 50);
            this.yRotate21.TabIndex = 0;
            this.yRotate21.UseVisualStyleBackColor = false;
            this.yRotate21.Click += new System.EventHandler(this.yRotate21_Click);
            // 
            // yRotate01
            // 
            this.yRotate01.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.yRotate01.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.yRotate01.FlatAppearance.BorderSize = 0;
            this.yRotate01.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.yRotate01.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.yRotate01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yRotate01.ForeColor = System.Drawing.Color.Green;
            this.yRotate01.Image = ((System.Drawing.Image)(resources.GetObject("yRotate01.Image")));
            this.yRotate01.Location = new System.Drawing.Point(446, 106);
            this.yRotate01.Name = "yRotate01";
            this.yRotate01.Size = new System.Drawing.Size(50, 50);
            this.yRotate01.TabIndex = 0;
            this.yRotate01.UseVisualStyleBackColor = false;
            this.yRotate01.Click += new System.EventHandler(this.yRotate1_Click);
            // 
            // yRotate11
            // 
            this.yRotate11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.yRotate11.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.yRotate11.FlatAppearance.BorderSize = 0;
            this.yRotate11.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.yRotate11.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.yRotate11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yRotate11.Image = ((System.Drawing.Image)(resources.GetObject("yRotate11.Image")));
            this.yRotate11.Location = new System.Drawing.Point(377, 65);
            this.yRotate11.Name = "yRotate11";
            this.yRotate11.Size = new System.Drawing.Size(50, 50);
            this.yRotate11.TabIndex = 0;
            this.yRotate11.UseVisualStyleBackColor = false;
            this.yRotate11.Click += new System.EventHandler(this.yRotate11_Click);
            // 
            // xRotate11
            // 
            this.xRotate11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.xRotate11.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.xRotate11.FlatAppearance.BorderSize = 0;
            this.xRotate11.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.xRotate11.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.xRotate11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xRotate11.Image = ((System.Drawing.Image)(resources.GetObject("xRotate11.Image")));
            this.xRotate11.Location = new System.Drawing.Point(363, 492);
            this.xRotate11.Name = "xRotate11";
            this.xRotate11.Size = new System.Drawing.Size(50, 50);
            this.xRotate11.TabIndex = 0;
            this.xRotate11.UseVisualStyleBackColor = false;
            this.xRotate11.Click += new System.EventHandler(this.xRotate11_Click);
            // 
            // xRotate21
            // 
            this.xRotate21.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.xRotate21.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.xRotate21.FlatAppearance.BorderSize = 0;
            this.xRotate21.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.xRotate21.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.xRotate21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xRotate21.Image = ((System.Drawing.Image)(resources.GetObject("xRotate21.Image")));
            this.xRotate21.Location = new System.Drawing.Point(433, 453);
            this.xRotate21.Name = "xRotate21";
            this.xRotate21.Size = new System.Drawing.Size(50, 50);
            this.xRotate21.TabIndex = 0;
            this.xRotate21.UseVisualStyleBackColor = false;
            this.xRotate21.Click += new System.EventHandler(this.xRotate21_Click);
            // 
            // xRotate01
            // 
            this.xRotate01.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.xRotate01.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.xRotate01.FlatAppearance.BorderSize = 0;
            this.xRotate01.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.xRotate01.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.xRotate01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xRotate01.Image = ((System.Drawing.Image)(resources.GetObject("xRotate01.Image")));
            this.xRotate01.Location = new System.Drawing.Point(291, 533);
            this.xRotate01.Name = "xRotate01";
            this.xRotate01.Size = new System.Drawing.Size(50, 50);
            this.xRotate01.TabIndex = 0;
            this.xRotate01.UseVisualStyleBackColor = false;
            this.xRotate01.Click += new System.EventHandler(this.xRotate01_Click);
            // 
            // yRotate00
            // 
            this.yRotate00.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.yRotate00.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.yRotate00.FlatAppearance.BorderSize = 0;
            this.yRotate00.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.yRotate00.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.yRotate00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yRotate00.Image = ((System.Drawing.Image)(resources.GetObject("yRotate00.Image")));
            this.yRotate00.Location = new System.Drawing.Point(209, 533);
            this.yRotate00.Name = "yRotate00";
            this.yRotate00.Size = new System.Drawing.Size(50, 50);
            this.yRotate00.TabIndex = 0;
            this.yRotate00.UseVisualStyleBackColor = false;
            this.yRotate00.Click += new System.EventHandler(this.yRotate00_Click);
            // 
            // yRotate10
            // 
            this.yRotate10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.yRotate10.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.yRotate10.FlatAppearance.BorderSize = 0;
            this.yRotate10.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.yRotate10.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.yRotate10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yRotate10.Image = ((System.Drawing.Image)(resources.GetObject("yRotate10.Image")));
            this.yRotate10.Location = new System.Drawing.Point(137, 492);
            this.yRotate10.Name = "yRotate10";
            this.yRotate10.Size = new System.Drawing.Size(50, 50);
            this.yRotate10.TabIndex = 0;
            this.yRotate10.UseVisualStyleBackColor = false;
            this.yRotate10.Click += new System.EventHandler(this.yRotate10_Click);
            // 
            // zRotate21
            // 
            this.zRotate21.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.zRotate21.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.zRotate21.FlatAppearance.BorderSize = 0;
            this.zRotate21.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.zRotate21.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.zRotate21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zRotate21.Image = ((System.Drawing.Image)(resources.GetObject("zRotate21.Image")));
            this.zRotate21.Location = new System.Drawing.Point(3, 349);
            this.zRotate21.Name = "zRotate21";
            this.zRotate21.Size = new System.Drawing.Size(50, 50);
            this.zRotate21.TabIndex = 0;
            this.zRotate21.UseVisualStyleBackColor = false;
            this.zRotate21.Click += new System.EventHandler(this.zRotate21_Click);
            // 
            // xRotateAll
            // 
            this.xRotateAll.BackColor = System.Drawing.Color.Transparent;
            this.xRotateAll.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.xRotateAll.FlatAppearance.BorderSize = 0;
            this.xRotateAll.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.xRotateAll.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.xRotateAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xRotateAll.Image = ((System.Drawing.Image)(resources.GetObject("xRotateAll.Image")));
            this.xRotateAll.Location = new System.Drawing.Point(143, 336);
            this.xRotateAll.Name = "xRotateAll";
            this.xRotateAll.Size = new System.Drawing.Size(50, 50);
            this.xRotateAll.TabIndex = 0;
            this.xRotateAll.UseVisualStyleBackColor = false;
            this.xRotateAll.Click += new System.EventHandler(this.xRotateAll_Click);
            // 
            // zRotateAll
            // 
            this.zRotateAll.BackColor = System.Drawing.Color.Transparent;
            this.zRotateAll.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.zRotateAll.FlatAppearance.BorderSize = 0;
            this.zRotateAll.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.zRotateAll.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.zRotateAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zRotateAll.Image = ((System.Drawing.Image)(resources.GetObject("zRotateAll.Image")));
            this.zRotateAll.Location = new System.Drawing.Point(251, 150);
            this.zRotateAll.Name = "zRotateAll";
            this.zRotateAll.Size = new System.Drawing.Size(50, 50);
            this.zRotateAll.TabIndex = 0;
            this.zRotateAll.UseVisualStyleBackColor = false;
            this.zRotateAll.Click += new System.EventHandler(this.zRotateAll_Click);
            // 
            // yRotate20
            // 
            this.yRotate20.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.yRotate20.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.yRotate20.FlatAppearance.BorderSize = 0;
            this.yRotate20.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.yRotate20.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.yRotate20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yRotate20.Image = ((System.Drawing.Image)(resources.GetObject("yRotate20.Image")));
            this.yRotate20.Location = new System.Drawing.Point(67, 453);
            this.yRotate20.Name = "yRotate20";
            this.yRotate20.Size = new System.Drawing.Size(50, 50);
            this.yRotate20.TabIndex = 0;
            this.yRotate20.UseVisualStyleBackColor = false;
            this.yRotate20.Click += new System.EventHandler(this.yRotate20_Click);
            // 
            // zRotate10
            // 
            this.zRotate10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.zRotate10.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.zRotate10.FlatAppearance.BorderSize = 0;
            this.zRotate10.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.zRotate10.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.zRotate10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zRotate10.Image = ((System.Drawing.Image)(resources.GetObject("zRotate10.Image")));
            this.zRotate10.Location = new System.Drawing.Point(497, 268);
            this.zRotate10.Name = "zRotate10";
            this.zRotate10.Size = new System.Drawing.Size(50, 50);
            this.zRotate10.TabIndex = 0;
            this.zRotate10.UseVisualStyleBackColor = false;
            this.zRotate10.Click += new System.EventHandler(this.zRotate10_Click);
            // 
            // zRotate11
            // 
            this.zRotate11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.zRotate11.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.zRotate11.FlatAppearance.BorderSize = 0;
            this.zRotate11.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.zRotate11.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.zRotate11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zRotate11.Image = ((System.Drawing.Image)(resources.GetObject("zRotate11.Image")));
            this.zRotate11.Location = new System.Drawing.Point(3, 268);
            this.zRotate11.Name = "zRotate11";
            this.zRotate11.Size = new System.Drawing.Size(50, 50);
            this.zRotate11.TabIndex = 0;
            this.zRotate11.UseVisualStyleBackColor = false;
            this.zRotate11.Click += new System.EventHandler(this.zRotate11_Click);
            // 
            // zRotate00
            // 
            this.zRotate00.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.zRotate00.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.zRotate00.FlatAppearance.BorderSize = 0;
            this.zRotate00.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.zRotate00.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.zRotate00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zRotate00.Image = ((System.Drawing.Image)(resources.GetObject("zRotate00.Image")));
            this.zRotate00.Location = new System.Drawing.Point(497, 183);
            this.zRotate00.Name = "zRotate00";
            this.zRotate00.Size = new System.Drawing.Size(50, 50);
            this.zRotate00.TabIndex = 0;
            this.zRotate00.UseVisualStyleBackColor = false;
            this.zRotate00.Click += new System.EventHandler(this.zRotate00_Click);
            // 
            // zRotate01
            // 
            this.zRotate01.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.zRotate01.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.zRotate01.FlatAppearance.BorderSize = 0;
            this.zRotate01.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.zRotate01.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.zRotate01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zRotate01.Image = ((System.Drawing.Image)(resources.GetObject("zRotate01.Image")));
            this.zRotate01.Location = new System.Drawing.Point(3, 183);
            this.zRotate01.Name = "zRotate01";
            this.zRotate01.Size = new System.Drawing.Size(50, 50);
            this.zRotate01.TabIndex = 0;
            this.zRotate01.UseVisualStyleBackColor = false;
            this.zRotate01.Click += new System.EventHandler(this.zRotate01_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1243, 618);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1259, 657);
            this.Name = "Form1";
            this.Text = "Rubiks Cube";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RoundButton zRotate01;
        private RoundButton zRotate20;
        private RoundButton yRotate11;
        private RoundButton yRotate20;
        private RoundButton zRotate11;
        private RoundButton xRotate00;
        private RoundButton xRotate10;
        private RoundButton xRotate20;
        private RoundButton yRotate21;
        private RoundButton yRotate01;
        private RoundButton xRotate11;
        private RoundButton xRotate21;
        private RoundButton xRotate01;
        private RoundButton yRotate00;
        private RoundButton yRotate10;
        private RoundButton zRotate21;
        private RoundButton zRotate10;
        private RoundButton zRotate00;
        private RoundButton yRotateAll;
        private RoundButton xRotateAll;
        private RoundButton zRotateAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

