namespace GenareteSignature
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
            this.lblHttpMethod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccessToken = new System.Windows.Forms.TextBox();
            this.txtAPIEndpointURL = new System.Windows.Forms.TextBox();
            this.cmbHttpMethod = new System.Windows.Forms.ComboBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.txtPostRequestBody = new System.Windows.Forms.TextBox();
            this.txtSignature = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSignature = new System.Windows.Forms.Label();
            this.btnSignature = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnCopySignature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHttpMethod
            // 
            this.lblHttpMethod.AutoSize = true;
            this.lblHttpMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHttpMethod.Location = new System.Drawing.Point(12, 21);
            this.lblHttpMethod.Name = "lblHttpMethod";
            this.lblHttpMethod.Size = new System.Drawing.Size(116, 16);
            this.lblHttpMethod.TabIndex = 0;
            this.lblHttpMethod.Text = "HTTP Method : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(329, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Access Token : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "API Endpoint URL :";
            // 
            // txtAccessToken
            // 
            this.txtAccessToken.Location = new System.Drawing.Point(443, 20);
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.Size = new System.Drawing.Size(611, 20);
            this.txtAccessToken.TabIndex = 3;
            // 
            // txtAPIEndpointURL
            // 
            this.txtAPIEndpointURL.Location = new System.Drawing.Point(157, 54);
            this.txtAPIEndpointURL.Name = "txtAPIEndpointURL";
            this.txtAPIEndpointURL.Size = new System.Drawing.Size(897, 20);
            this.txtAPIEndpointURL.TabIndex = 4;
            // 
            // cmbHttpMethod
            // 
            this.cmbHttpMethod.FormattingEnabled = true;
            this.cmbHttpMethod.Items.AddRange(new object[] {
            "Seçiniz",
            "GET",
            "POST"});
            this.cmbHttpMethod.Location = new System.Drawing.Point(157, 20);
            this.cmbHttpMethod.Name = "cmbHttpMethod";
            this.cmbHttpMethod.Size = new System.Drawing.Size(152, 21);
            this.cmbHttpMethod.TabIndex = 5;
            this.cmbHttpMethod.SelectedIndexChanged += new System.EventHandler(this.cmbHttpMethod_SelectedIndexChanged);
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(15, 111);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPrivateKey.Size = new System.Drawing.Size(334, 304);
            this.txtPrivateKey.TabIndex = 6;
            // 
            // txtPostRequestBody
            // 
            this.txtPostRequestBody.Location = new System.Drawing.Point(367, 111);
            this.txtPostRequestBody.Multiline = true;
            this.txtPostRequestBody.Name = "txtPostRequestBody";
            this.txtPostRequestBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPostRequestBody.Size = new System.Drawing.Size(334, 304);
            this.txtPostRequestBody.TabIndex = 7;
            // 
            // txtSignature
            // 
            this.txtSignature.Location = new System.Drawing.Point(720, 111);
            this.txtSignature.Multiline = true;
            this.txtSignature.Name = "txtSignature";
            this.txtSignature.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSignature.Size = new System.Drawing.Size(334, 304);
            this.txtSignature.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(122, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Private Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(454, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "POST Request Body";
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignature.Location = new System.Drawing.Point(822, 92);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(74, 16);
            this.lblSignature.TabIndex = 11;
            this.lblSignature.Text = "Signature";
            // 
            // btnSignature
            // 
            this.btnSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignature.Location = new System.Drawing.Point(15, 421);
            this.btnSignature.Name = "btnSignature";
            this.btnSignature.Size = new System.Drawing.Size(334, 39);
            this.btnSignature.TabIndex = 12;
            this.btnSignature.Text = "Generate Signature";
            this.btnSignature.UseVisualStyleBackColor = true;
            this.btnSignature.Click += new System.EventHandler(this.btnSignature_Click);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClean.Location = new System.Drawing.Point(367, 421);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(334, 39);
            this.btnClean.TabIndex = 13;
            this.btnClean.Text = "Clean Form";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnCopySignature
            // 
            this.btnCopySignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCopySignature.Location = new System.Drawing.Point(720, 421);
            this.btnCopySignature.Name = "btnCopySignature";
            this.btnCopySignature.Size = new System.Drawing.Size(334, 39);
            this.btnCopySignature.TabIndex = 14;
            this.btnCopySignature.Text = "Copy To ClipBoard";
            this.btnCopySignature.UseVisualStyleBackColor = true;
            this.btnCopySignature.Click += new System.EventHandler(this.btnCopySignature_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 470);
            this.Controls.Add(this.btnCopySignature);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSignature);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSignature);
            this.Controls.Add(this.txtPostRequestBody);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.cmbHttpMethod);
            this.Controls.Add(this.txtAPIEndpointURL);
            this.Controls.Add(this.txtAccessToken);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHttpMethod);
            this.Name = "Form1";
            this.Text = "Generate Signature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHttpMethod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccessToken;
        private System.Windows.Forms.TextBox txtAPIEndpointURL;
        private System.Windows.Forms.ComboBox cmbHttpMethod;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.TextBox txtPostRequestBody;
        private System.Windows.Forms.TextBox txtSignature;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.Button btnSignature;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnCopySignature;
    }
}

