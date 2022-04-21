namespace EX_04_CountdownTimer
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
            this.textBox_timer = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_checkErrors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_timer
            // 
            this.textBox_timer.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBox_timer.Location = new System.Drawing.Point(277, 115);
            this.textBox_timer.Name = "textBox_timer";
            this.textBox_timer.Size = new System.Drawing.Size(194, 57);
            this.textBox_timer.TabIndex = 0;
            this.textBox_timer.Text = "00:00";
            this.textBox_timer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_timer.TextChanged += new System.EventHandler(this.textBox_timer_TextChanged);
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button_start.Location = new System.Drawing.Point(277, 199);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(194, 74);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Start!";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button_clear.Location = new System.Drawing.Point(377, 278);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(94, 74);
            this.button_clear.TabIndex = 2;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_stop
            // 
            this.button_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button_stop.Location = new System.Drawing.Point(277, 278);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(94, 73);
            this.button_stop.TabIndex = 3;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_checkErrors
            // 
            this.label_checkErrors.AutoSize = true;
            this.label_checkErrors.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label_checkErrors.Location = new System.Drawing.Point(302, 175);
            this.label_checkErrors.Name = "label_checkErrors";
            this.label_checkErrors.Size = new System.Drawing.Size(60, 22);
            this.label_checkErrors.TabIndex = 4;
            this.label_checkErrors.Text = "label1";
            this.label_checkErrors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_checkErrors.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_checkErrors);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textBox_timer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_timer;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_checkErrors;
    }
}

