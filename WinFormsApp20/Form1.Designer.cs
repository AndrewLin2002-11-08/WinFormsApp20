namespace WinFormsApp20
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
            this.label1inputdata = new System.Windows.Forms.Label();
            this.label2empty = new System.Windows.Forms.Label();
            this.textBox1input = new System.Windows.Forms.TextBox();
            this.button1proses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1inputdata
            // 
            this.label1inputdata.AutoSize = true;
            this.label1inputdata.Location = new System.Drawing.Point(73, 27);
            this.label1inputdata.Name = "label1inputdata";
            this.label1inputdata.Size = new System.Drawing.Size(100, 25);
            this.label1inputdata.TabIndex = 0;
            this.label1inputdata.Text = "Input Data:";
            // 
            // label2empty
            // 
            this.label2empty.AutoSize = true;
            this.label2empty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2empty.Location = new System.Drawing.Point(73, 199);
            this.label2empty.Name = "label2empty";
            this.label2empty.Size = new System.Drawing.Size(134, 32);
            this.label2empty.TabIndex = 1;
            this.label2empty.Text = "[EMPTY]";
            // 
            // textBox1input
            // 
            this.textBox1input.Location = new System.Drawing.Point(73, 77);
            this.textBox1input.Name = "textBox1input";
            this.textBox1input.Size = new System.Drawing.Size(640, 31);
            this.textBox1input.TabIndex = 2;
            // 
            // button1proses
            // 
            this.button1proses.Location = new System.Drawing.Point(73, 134);
            this.button1proses.Name = "button1proses";
            this.button1proses.Size = new System.Drawing.Size(112, 34);
            this.button1proses.TabIndex = 3;
            this.button1proses.Text = "Proses";
            this.button1proses.UseVisualStyleBackColor = true;
            this.button1proses.Click += new System.EventHandler(this.button1proses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1proses);
            this.Controls.Add(this.textBox1input);
            this.Controls.Add(this.label2empty);
            this.Controls.Add(this.label1inputdata);
            this.Name = "Form1";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1inputdata;
        private Label label2empty;
        private TextBox textBox1input;
        private Button button1proses;
    }
}