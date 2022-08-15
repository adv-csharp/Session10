namespace GrpcClient
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
            this.btnGRPC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGRPC
            // 
            this.btnGRPC.Location = new System.Drawing.Point(294, 177);
            this.btnGRPC.Name = "btnGRPC";
            this.btnGRPC.Size = new System.Drawing.Size(178, 47);
            this.btnGRPC.TabIndex = 0;
            this.btnGRPC.Text = "Call GRPC";
            this.btnGRPC.UseVisualStyleBackColor = true;
            this.btnGRPC.Click += new System.EventHandler(this.btnGRPC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGRPC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGRPC;
    }
}