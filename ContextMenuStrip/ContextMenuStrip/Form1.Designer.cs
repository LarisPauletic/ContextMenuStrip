namespace ContextMenuStrip
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
            this.txtBxLijevo = new System.Windows.Forms.TextBox();
            this.txtBxDesno = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lijevoNaDesnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desnoNaLijevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBxLijevo
            // 
            this.txtBxLijevo.ContextMenuStrip = this.contextMenuStrip1;
            this.txtBxLijevo.Location = new System.Drawing.Point(230, 208);
            this.txtBxLijevo.Name = "txtBxLijevo";
            this.txtBxLijevo.Size = new System.Drawing.Size(131, 22);
            this.txtBxLijevo.TabIndex = 0;
            // 
            // txtBxDesno
            // 
            this.txtBxDesno.ContextMenuStrip = this.contextMenuStrip1;
            this.txtBxDesno.Location = new System.Drawing.Point(456, 208);
            this.txtBxDesno.Name = "txtBxDesno";
            this.txtBxDesno.Size = new System.Drawing.Size(131, 22);
            this.txtBxDesno.TabIndex = 1;
            this.txtBxDesno.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lijevoNaDesnoToolStripMenuItem,
            this.desnoNaLijevoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 52);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening_2);
            // 
            // lijevoNaDesnoToolStripMenuItem
            // 
            this.lijevoNaDesnoToolStripMenuItem.Name = "lijevoNaDesnoToolStripMenuItem";
            this.lijevoNaDesnoToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.lijevoNaDesnoToolStripMenuItem.Text = "Lijevo na desno";
            this.lijevoNaDesnoToolStripMenuItem.Click += new System.EventHandler(this.lijevoNaDesnoToolStripMenuItem_Click);
            // 
            // desnoNaLijevoToolStripMenuItem
            // 
            this.desnoNaLijevoToolStripMenuItem.Name = "desnoNaLijevoToolStripMenuItem";
            this.desnoNaLijevoToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.desnoNaLijevoToolStripMenuItem.Text = "Desno na lijevo";
            this.desnoNaLijevoToolStripMenuItem.Click += new System.EventHandler(this.desnoNaLijevoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBxDesno);
            this.Controls.Add(this.txtBxLijevo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxLijevo;
        private System.Windows.Forms.TextBox txtBxDesno;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lijevoNaDesnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desnoNaLijevoToolStripMenuItem;
    }
}

