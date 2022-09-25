namespace Klasa_Process
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
            this.buttonExplorer = new System.Windows.Forms.Button();
            this.buttonWord = new System.Windows.Forms.Button();
            this.buttonStartInfo = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExplorer
            // 
            this.buttonExplorer.Location = new System.Drawing.Point(49, 39);
            this.buttonExplorer.Name = "buttonExplorer";
            this.buttonExplorer.Size = new System.Drawing.Size(138, 23);
            this.buttonExplorer.TabIndex = 0;
            this.buttonExplorer.Text = "Pokreni Internet explorer";
            this.buttonExplorer.UseVisualStyleBackColor = true;
            this.buttonExplorer.Click += new System.EventHandler(this.buttonExplorer_Click);
            // 
            // buttonWord
            // 
            this.buttonWord.Location = new System.Drawing.Point(49, 101);
            this.buttonWord.Name = "buttonWord";
            this.buttonWord.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonWord.Size = new System.Drawing.Size(138, 23);
            this.buttonWord.TabIndex = 1;
            this.buttonWord.Text = "Pokreni Word";
            this.buttonWord.UseVisualStyleBackColor = true;
            this.buttonWord.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonStartInfo
            // 
            this.buttonStartInfo.Location = new System.Drawing.Point(248, 101);
            this.buttonStartInfo.Name = "buttonStartInfo";
            this.buttonStartInfo.Size = new System.Drawing.Size(125, 23);
            this.buttonStartInfo.TabIndex = 2;
            this.buttonStartInfo.Text = "StartInfo";
            this.buttonStartInfo.UseVisualStyleBackColor = true;
            this.buttonStartInfo.Click += new System.EventHandler(this.buttonStartInfo_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Location = new System.Drawing.Point(248, 39);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(125, 23);
            this.buttonExcel.TabIndex = 3;
            this.buttonExcel.Text = "Pokreni Excel";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 165);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonStartInfo);
            this.Controls.Add(this.buttonWord);
            this.Controls.Add(this.buttonExplorer);
            this.Name = "Form1";
            this.Text = "Upotreba klase Process";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExplorer;
        private System.Windows.Forms.Button buttonWord;
        private System.Windows.Forms.Button buttonStartInfo;
        private System.Windows.Forms.Button buttonExcel;
    }
}

