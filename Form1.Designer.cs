
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.z3 = new System.Windows.Forms.Button();
            this.z2 = new System.Windows.Forms.Button();
            this.z1 = new System.Windows.Forms.Button();
            this.y1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(62, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 500);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // z3
            // 
            this.z3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.z3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.z3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.z3.Location = new System.Drawing.Point(9, 291);
            this.z3.Margin = new System.Windows.Forms.Padding(0);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(50, 50);
            this.z3.TabIndex = 0;
            this.z3.Text = "<";
            this.z3.UseVisualStyleBackColor = false;
            // 
            // z2
            // 
            this.z2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.z2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.z2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.z2.Location = new System.Drawing.Point(9, 230);
            this.z2.Margin = new System.Windows.Forms.Padding(0);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(50, 50);
            this.z2.TabIndex = 0;
            this.z2.Text = "<";
            this.z2.UseVisualStyleBackColor = false;
            this.z2.Click += new System.EventHandler(this.z2_Click);
            // 
            // z1
            // 
            this.z1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.z1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.z1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.z1.Location = new System.Drawing.Point(9, 167);
            this.z1.Margin = new System.Windows.Forms.Padding(0);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(50, 50);
            this.z1.TabIndex = 0;
            this.z1.Text = "<";
            this.z1.UseVisualStyleBackColor = false;
            this.z1.Click += new System.EventHandler(this.z1_Click);
            // 
            // y1
            // 
            this.y1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.y1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y1.Location = new System.Drawing.Point(489, 123);
            this.y1.Margin = new System.Windows.Forms.Padding(0);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(50, 50);
            this.y1.TabIndex = 0;
            this.y1.Text = ">";
            this.y1.UseVisualStyleBackColor = false;
            this.y1.Click += new System.EventHandler(this.y1_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(627, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 406);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1208, 620);
            this.Controls.Add(this.z3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button z1;
        private System.Windows.Forms.Button z3;
        private System.Windows.Forms.Button z2;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button y1;
        private System.Windows.Forms.Panel panel2;
    }
}

