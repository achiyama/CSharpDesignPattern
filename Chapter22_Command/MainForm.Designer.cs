namespace Chapter22_Command
{
    partial class MainForm
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
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DrawCanvas = new Chapter22_Command.Drawer.DrawCanvas();
            this.SuspendLayout();
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(200, 12);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 0;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DrawCanvas
            // 
            this.DrawCanvas.BackColor = System.Drawing.SystemColors.Window;
            this.DrawCanvas.Location = new System.Drawing.Point(40, 40);
            this.DrawCanvas.Name = "DrawCanvas";
            this.DrawCanvas.Size = new System.Drawing.Size(400, 400);
            this.DrawCanvas.TabIndex = 1;
            this.DrawCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawCanvas_MouseDown);
            this.DrawCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawCanvas_MouseMove);
            this.DrawCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawCanvas_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.DrawCanvas);
            this.Controls.Add(this.ClearBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ClearBtn;
        private Drawer.DrawCanvas DrawCanvas;
    }
}