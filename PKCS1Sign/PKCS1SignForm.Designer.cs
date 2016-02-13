namespace PKCS1Signature
{
    partial class signForm
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
            this.inputPrivateModulus = new System.Windows.Forms.TextBox();
            this.lblPrimeNumber1 = new System.Windows.Forms.Label();
            this.inputPlainText = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.inputSignature = new System.Windows.Forms.TextBox();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.dlgPlainFileLoad = new System.Windows.Forms.OpenFileDialog();
            this.lblPrimeNumber2 = new System.Windows.Forms.Label();
            this.inputPrivateExponent = new System.Windows.Forms.TextBox();
            this.btnPlainLoad = new System.Windows.Forms.Button();
            this.btnPlainSave = new System.Windows.Forms.Button();
            this.btnSignatureSave = new System.Windows.Forms.Button();
            this.btnSignatureLoad = new System.Windows.Forms.Button();
            this.dlgSignFileLoad = new System.Windows.Forms.OpenFileDialog();
            this.dlgPlainFileSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgSignatureFileSave = new System.Windows.Forms.SaveFileDialog();
            this.grpPrivateKey = new System.Windows.Forms.GroupBox();
            this.btnGeneratePrivateKey = new System.Windows.Forms.Button();
            this.grpPublicKey = new System.Windows.Forms.GroupBox();
            this.btnGeneratePublicKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputPublicModulus = new System.Windows.Forms.TextBox();
            this.inputPublicExponent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpPrivateKey.SuspendLayout();
            this.grpPublicKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputPrivateModulus
            // 
            this.inputPrivateModulus.Location = new System.Drawing.Point(23, 44);
            this.inputPrivateModulus.Name = "inputPrivateModulus";
            this.inputPrivateModulus.ReadOnly = true;
            this.inputPrivateModulus.Size = new System.Drawing.Size(202, 20);
            this.inputPrivateModulus.TabIndex = 0;
            // 
            // lblPrimeNumber1
            // 
            this.lblPrimeNumber1.AutoSize = true;
            this.lblPrimeNumber1.Location = new System.Drawing.Point(23, 25);
            this.lblPrimeNumber1.Name = "lblPrimeNumber1";
            this.lblPrimeNumber1.Size = new System.Drawing.Size(47, 13);
            this.lblPrimeNumber1.TabIndex = 1;
            this.lblPrimeNumber1.Text = "Modulus";
            // 
            // inputPlainText
            // 
            this.inputPlainText.Location = new System.Drawing.Point(26, 175);
            this.inputPlainText.Multiline = true;
            this.inputPlainText.Name = "inputPlainText";
            this.inputPlainText.Size = new System.Drawing.Size(199, 138);
            this.inputPlainText.TabIndex = 2;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(23, 156);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(50, 13);
            this.lblInput.TabIndex = 3;
            this.lblInput.Text = "Plain text";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(319, 156);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(52, 13);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Signature";
            // 
            // inputSignature
            // 
            this.inputSignature.Location = new System.Drawing.Point(322, 175);
            this.inputSignature.Multiline = true;
            this.inputSignature.Name = "inputSignature";
            this.inputSignature.ReadOnly = true;
            this.inputSignature.Size = new System.Drawing.Size(197, 138);
            this.inputSignature.TabIndex = 4;
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(243, 206);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(73, 23);
            this.btnSign.TabIndex = 9;
            this.btnSign.Text = "Sign =>";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(243, 249);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(73, 23);
            this.btnDecrypt.TabIndex = 8;
            this.btnDecrypt.Text = "<= Verify";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // dlgPlainFileLoad
            // 
            this.dlgPlainFileLoad.Filter = "Plain text|*.txt";
            // 
            // lblPrimeNumber2
            // 
            this.lblPrimeNumber2.AutoSize = true;
            this.lblPrimeNumber2.Location = new System.Drawing.Point(23, 70);
            this.lblPrimeNumber2.Name = "lblPrimeNumber2";
            this.lblPrimeNumber2.Size = new System.Drawing.Size(52, 13);
            this.lblPrimeNumber2.TabIndex = 11;
            this.lblPrimeNumber2.Text = "Exponent";
            // 
            // inputPrivateExponent
            // 
            this.inputPrivateExponent.Location = new System.Drawing.Point(23, 89);
            this.inputPrivateExponent.Name = "inputPrivateExponent";
            this.inputPrivateExponent.ReadOnly = true;
            this.inputPrivateExponent.Size = new System.Drawing.Size(202, 20);
            this.inputPrivateExponent.TabIndex = 1;
            // 
            // btnPlainLoad
            // 
            this.btnPlainLoad.Location = new System.Drawing.Point(140, 151);
            this.btnPlainLoad.Name = "btnPlainLoad";
            this.btnPlainLoad.Size = new System.Drawing.Size(42, 23);
            this.btnPlainLoad.TabIndex = 12;
            this.btnPlainLoad.Text = "Load";
            this.btnPlainLoad.UseVisualStyleBackColor = true;
            this.btnPlainLoad.Click += new System.EventHandler(this.btnPlainLoad_Click);
            // 
            // btnPlainSave
            // 
            this.btnPlainSave.Location = new System.Drawing.Point(183, 151);
            this.btnPlainSave.Name = "btnPlainSave";
            this.btnPlainSave.Size = new System.Drawing.Size(42, 23);
            this.btnPlainSave.TabIndex = 13;
            this.btnPlainSave.Text = "Save";
            this.btnPlainSave.UseVisualStyleBackColor = true;
            this.btnPlainSave.Click += new System.EventHandler(this.btnPlainSave_Click);
            // 
            // btnSignatureSave
            // 
            this.btnSignatureSave.Location = new System.Drawing.Point(477, 151);
            this.btnSignatureSave.Name = "btnSignatureSave";
            this.btnSignatureSave.Size = new System.Drawing.Size(42, 23);
            this.btnSignatureSave.TabIndex = 15;
            this.btnSignatureSave.Text = "Save";
            this.btnSignatureSave.UseVisualStyleBackColor = true;
            this.btnSignatureSave.Click += new System.EventHandler(this.btnEncryptedSave_Click);
            // 
            // btnSignatureLoad
            // 
            this.btnSignatureLoad.Location = new System.Drawing.Point(434, 151);
            this.btnSignatureLoad.Name = "btnSignatureLoad";
            this.btnSignatureLoad.Size = new System.Drawing.Size(42, 23);
            this.btnSignatureLoad.TabIndex = 14;
            this.btnSignatureLoad.Text = "Load";
            this.btnSignatureLoad.UseVisualStyleBackColor = true;
            this.btnSignatureLoad.Click += new System.EventHandler(this.btnSignatureLoad_Click);
            // 
            // dlgSignFileLoad
            // 
            this.dlgSignFileLoad.Filter = "Ecrypted files|*.dat";
            // 
            // dlgPlainFileSave
            // 
            this.dlgPlainFileSave.Filter = "Plain text|*.txt";
            // 
            // dlgSignatureFileSave
            // 
            this.dlgSignatureFileSave.Filter = "Encrypted data|*.dat";
            // 
            // grpPrivateKey
            // 
            this.grpPrivateKey.Controls.Add(this.btnGeneratePrivateKey);
            this.grpPrivateKey.Controls.Add(this.lblPrimeNumber1);
            this.grpPrivateKey.Controls.Add(this.inputPrivateModulus);
            this.grpPrivateKey.Controls.Add(this.inputPrivateExponent);
            this.grpPrivateKey.Controls.Add(this.lblPrimeNumber2);
            this.grpPrivateKey.Location = new System.Drawing.Point(26, 12);
            this.grpPrivateKey.Name = "grpPrivateKey";
            this.grpPrivateKey.Size = new System.Drawing.Size(244, 127);
            this.grpPrivateKey.TabIndex = 16;
            this.grpPrivateKey.TabStop = false;
            this.grpPrivateKey.Text = "Private key";
            // 
            // btnGeneratePrivateKey
            // 
            this.btnGeneratePrivateKey.Location = new System.Drawing.Point(157, 15);
            this.btnGeneratePrivateKey.Name = "btnGeneratePrivateKey";
            this.btnGeneratePrivateKey.Size = new System.Drawing.Size(68, 23);
            this.btnGeneratePrivateKey.TabIndex = 12;
            this.btnGeneratePrivateKey.Text = "Generate";
            this.btnGeneratePrivateKey.UseVisualStyleBackColor = true;
            this.btnGeneratePrivateKey.Click += new System.EventHandler(this.btnGeneratePrivateKey_Click);
            // 
            // grpPublicKey
            // 
            this.grpPublicKey.Controls.Add(this.btnGeneratePublicKey);
            this.grpPublicKey.Controls.Add(this.label1);
            this.grpPublicKey.Controls.Add(this.inputPublicModulus);
            this.grpPublicKey.Controls.Add(this.inputPublicExponent);
            this.grpPublicKey.Controls.Add(this.label2);
            this.grpPublicKey.Location = new System.Drawing.Point(276, 12);
            this.grpPublicKey.Name = "grpPublicKey";
            this.grpPublicKey.Size = new System.Drawing.Size(244, 127);
            this.grpPublicKey.TabIndex = 17;
            this.grpPublicKey.TabStop = false;
            this.grpPublicKey.Text = "Public key";
            // 
            // btnGeneratePublicKey
            // 
            this.btnGeneratePublicKey.Location = new System.Drawing.Point(158, 15);
            this.btnGeneratePublicKey.Name = "btnGeneratePublicKey";
            this.btnGeneratePublicKey.Size = new System.Drawing.Size(68, 23);
            this.btnGeneratePublicKey.TabIndex = 13;
            this.btnGeneratePublicKey.Text = "Generate";
            this.btnGeneratePublicKey.UseVisualStyleBackColor = true;
            this.btnGeneratePublicKey.Click += new System.EventHandler(this.btnGeneratePublicKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modulus";
            // 
            // inputPublicModulus
            // 
            this.inputPublicModulus.Location = new System.Drawing.Point(22, 44);
            this.inputPublicModulus.Name = "inputPublicModulus";
            this.inputPublicModulus.ReadOnly = true;
            this.inputPublicModulus.Size = new System.Drawing.Size(202, 20);
            this.inputPublicModulus.TabIndex = 0;
            // 
            // inputPublicExponent
            // 
            this.inputPublicExponent.Location = new System.Drawing.Point(22, 89);
            this.inputPublicExponent.Name = "inputPublicExponent";
            this.inputPublicExponent.ReadOnly = true;
            this.inputPublicExponent.Size = new System.Drawing.Size(202, 20);
            this.inputPublicExponent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Exponent";
            // 
            // signForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 328);
            this.Controls.Add(this.grpPublicKey);
            this.Controls.Add(this.grpPrivateKey);
            this.Controls.Add(this.btnSignatureSave);
            this.Controls.Add(this.btnSignatureLoad);
            this.Controls.Add(this.btnPlainSave);
            this.Controls.Add(this.btnPlainLoad);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.inputSignature);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.inputPlainText);
            this.Name = "signForm";
            this.Text = "PKCS#1 (Signature)";
            this.grpPrivateKey.ResumeLayout(false);
            this.grpPrivateKey.PerformLayout();
            this.grpPublicKey.ResumeLayout(false);
            this.grpPublicKey.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputPrivateModulus;
        private System.Windows.Forms.Label lblPrimeNumber1;
        private System.Windows.Forms.TextBox inputPlainText;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox inputSignature;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.OpenFileDialog dlgPlainFileLoad;
        private System.Windows.Forms.Label lblPrimeNumber2;
        private System.Windows.Forms.TextBox inputPrivateExponent;
        private System.Windows.Forms.Button btnPlainLoad;
        private System.Windows.Forms.Button btnPlainSave;
        private System.Windows.Forms.Button btnSignatureSave;
        private System.Windows.Forms.Button btnSignatureLoad;
        private System.Windows.Forms.OpenFileDialog dlgSignFileLoad;
        private System.Windows.Forms.SaveFileDialog dlgPlainFileSave;
        private System.Windows.Forms.SaveFileDialog dlgSignatureFileSave;
        private System.Windows.Forms.GroupBox grpPrivateKey;
        private System.Windows.Forms.Button btnGeneratePrivateKey;
        private System.Windows.Forms.GroupBox grpPublicKey;
        private System.Windows.Forms.Button btnGeneratePublicKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputPublicModulus;
        private System.Windows.Forms.TextBox inputPublicExponent;
        private System.Windows.Forms.Label label2;
    }
}

