namespace AssessmentWinForm
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
            this.labelProdId = new System.Windows.Forms.Label();
            this.labelProdName = new System.Windows.Forms.Label();
            this.labelProdPrice = new System.Windows.Forms.Label();
            this.textProdId = new System.Windows.Forms.TextBox();
            this.textProdName = new System.Windows.Forms.TextBox();
            this.textProdPrice = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelProdId
            // 
            this.labelProdId.AutoSize = true;
            this.labelProdId.Location = new System.Drawing.Point(106, 71);
            this.labelProdId.Name = "labelProdId";
            this.labelProdId.Size = new System.Drawing.Size(128, 20);
            this.labelProdId.TabIndex = 0;
            this.labelProdId.Text = "Enter Product ID";
            // 
            // labelProdName
            // 
            this.labelProdName.AutoSize = true;
            this.labelProdName.Location = new System.Drawing.Point(106, 137);
            this.labelProdName.Name = "labelProdName";
            this.labelProdName.Size = new System.Drawing.Size(153, 20);
            this.labelProdName.TabIndex = 1;
            this.labelProdName.Text = "Enter Product Name";
            // 
            // labelProdPrice
            // 
            this.labelProdPrice.AutoSize = true;
            this.labelProdPrice.Location = new System.Drawing.Point(106, 203);
            this.labelProdPrice.Name = "labelProdPrice";
            this.labelProdPrice.Size = new System.Drawing.Size(146, 20);
            this.labelProdPrice.TabIndex = 2;
            this.labelProdPrice.Text = "Enter Product Price";
            // 
            // textProdId
            // 
            this.textProdId.Location = new System.Drawing.Point(278, 65);
            this.textProdId.Name = "textProdId";
            this.textProdId.Size = new System.Drawing.Size(188, 26);
            this.textProdId.TabIndex = 3;
            // 
            // textProdName
            // 
            this.textProdName.Location = new System.Drawing.Point(278, 134);
            this.textProdName.Name = "textProdName";
            this.textProdName.Size = new System.Drawing.Size(188, 26);
            this.textProdName.TabIndex = 4;
            this.textProdName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textProdPrice
            // 
            this.textProdPrice.Location = new System.Drawing.Point(278, 197);
            this.textProdPrice.Name = "textProdPrice";
            this.textProdPrice.Size = new System.Drawing.Size(192, 26);
            this.textProdPrice.TabIndex = 5;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(110, 281);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(121, 48);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(278, 281);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(114, 48);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.textProdPrice);
            this.Controls.Add(this.textProdName);
            this.Controls.Add(this.textProdId);
            this.Controls.Add(this.labelProdPrice);
            this.Controls.Add(this.labelProdName);
            this.Controls.Add(this.labelProdId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProdId;
        private System.Windows.Forms.Label labelProdName;
        private System.Windows.Forms.Label labelProdPrice;
        private System.Windows.Forms.TextBox textProdId;
        private System.Windows.Forms.TextBox textProdName;
        private System.Windows.Forms.TextBox textProdPrice;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
    }
}

