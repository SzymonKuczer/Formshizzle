namespace WindowsFormsApp1
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
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(180, 107);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(165, 20);
            this.usernameInput.TabIndex = 0;
            this.usernameInput.Text = "Input Username";
            this.usernameInput.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(180, 153);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(165, 20);
            this.passwordInput.TabIndex = 1;
            this.passwordInput.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(180, 194);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(67, 24);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.MaximumSize = new System.Drawing.Size(500, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "E-Sports";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 50);
            this.label2.MaximumSize = new System.Drawing.Size(500, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trainer";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 289);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Location = new System.Drawing.Point(211, 117);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

