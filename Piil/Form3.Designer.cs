namespace Piil
{
    partial class Form3
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
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Label();
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Frame3 = new System.Windows.Forms.GroupBox();
            this.Frame1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Info;
            this.Frame1.Controls.Add(this.Frame3);
            this.Frame1.Controls.Add(this.btn_back);
            this.Frame1.Controls.Add(this.btn_clear);
            this.Frame1.Controls.Add(this.display);
            this.Frame1.Controls.Add(this.Frame2);
            this.Frame1.Location = new System.Drawing.Point(13, 13);
            this.Frame1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Frame1.Name = "Frame1";
            this.Frame1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Frame1.Size = new System.Drawing.Size(722, 661);
            this.Frame1.TabIndex = 0;
            this.Frame1.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_back.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btn_back.Location = new System.Drawing.Point(328, 143);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(168, 65);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "<--";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btn_clear.Location = new System.Drawing.Point(68, 139);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(176, 65);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "CLS";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.display.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.display.Location = new System.Drawing.Point(67, 20);
            this.display.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(576, 98);
            this.display.TabIndex = 11;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Frame2
            // 
            this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Frame2.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Frame2.Location = new System.Drawing.Point(68, 229);
            this.Frame2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Frame2.Name = "Frame2";
            this.Frame2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Frame2.Size = new System.Drawing.Size(428, 364);
            this.Frame2.TabIndex = 0;
            this.Frame2.TabStop = false;
            // 
            // Frame3
            // 
            this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Frame3.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Frame3.Location = new System.Drawing.Point(521, 229);
            this.Frame3.Margin = new System.Windows.Forms.Padding(4);
            this.Frame3.Name = "Frame3";
            this.Frame3.Padding = new System.Windows.Forms.Padding(4);
            this.Frame3.Size = new System.Drawing.Size(122, 364);
            this.Frame3.TabIndex = 1;
            this.Frame3.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 703);
            this.Controls.Add(this.Frame1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Frame1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Frame1;
        private System.Windows.Forms.GroupBox Frame2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.GroupBox Frame3;
    }
}