namespace BaseContainer
{
    partial class BaseGame
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
            this.bClear = new System.Windows.Forms.Button();
            this.bInput = new System.Windows.Forms.Button();
            this.statusLable = new System.Windows.Forms.Label();
            this.tNumber1 = new System.Windows.Forms.TextBox();
            this.tNumber2 = new System.Windows.Forms.TextBox();
            this.tNumber3 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(195, 12);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 0;
            this.bClear.Text = "button1";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bInput
            // 
            this.bInput.Location = new System.Drawing.Point(138, 119);
            this.bInput.Name = "bInput";
            this.bInput.Size = new System.Drawing.Size(75, 23);
            this.bInput.TabIndex = 1;
            this.bInput.Text = "button2";
            this.bInput.UseVisualStyleBackColor = true;
            this.bInput.Click += new System.EventHandler(this.bInput_Click);
            // 
            // statusLable
            // 
            this.statusLable.AutoSize = true;
            this.statusLable.Location = new System.Drawing.Point(34, 17);
            this.statusLable.Name = "statusLable";
            this.statusLable.Size = new System.Drawing.Size(38, 12);
            this.statusLable.TabIndex = 2;
            this.statusLable.Text = "label1";
            // 
            // tNumber1
            // 
            this.tNumber1.Location = new System.Drawing.Point(17, 65);
            this.tNumber1.Name = "tNumber1";
            this.tNumber1.Size = new System.Drawing.Size(100, 21);
            this.tNumber1.TabIndex = 3;
            // 
            // tNumber2
            // 
            this.tNumber2.Location = new System.Drawing.Point(17, 92);
            this.tNumber2.Name = "tNumber2";
            this.tNumber2.Size = new System.Drawing.Size(100, 21);
            this.tNumber2.TabIndex = 4;
            // 
            // tNumber3
            // 
            this.tNumber3.Location = new System.Drawing.Point(17, 119);
            this.tNumber3.Name = "tNumber3";
            this.tNumber3.Size = new System.Drawing.Size(100, 21);
            this.tNumber3.TabIndex = 5;
            // 
            // BaseGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 268);
            this.Controls.Add(this.tNumber3);
            this.Controls.Add(this.tNumber2);
            this.Controls.Add(this.tNumber1);
            this.Controls.Add(this.statusLable);
            this.Controls.Add(this.bInput);
            this.Controls.Add(this.bClear);
            this.Name = "BaseGame";
            this.Text = "BaseGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bInput;
        private System.Windows.Forms.Label statusLable;
        private System.Windows.Forms.TextBox tNumber1;
        private System.Windows.Forms.TextBox tNumber2;
        private System.Windows.Forms.TextBox tNumber3;
        private System.IO.Ports.SerialPort serialPort1;
    }
}