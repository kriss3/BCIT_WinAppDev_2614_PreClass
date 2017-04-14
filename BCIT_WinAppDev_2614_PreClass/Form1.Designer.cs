namespace BCIT_WinAppDev_2614_PreClass
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
			this.btnClose = new System.Windows.Forms.Button();
			this.tbOpacity = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.tbOpacity)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(224, 120);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 31);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// tbOpacity
			// 
			this.tbOpacity.Location = new System.Drawing.Point(12, 12);
			this.tbOpacity.Maximum = 100;
			this.tbOpacity.Minimum = 50;
			this.tbOpacity.Name = "tbOpacity";
			this.tbOpacity.Size = new System.Drawing.Size(260, 45);
			this.tbOpacity.TabIndex = 1;
			this.tbOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbOpacity.Value = 100;
			this.tbOpacity.Scroll += new System.EventHandler(this.tbOpacity_Scroll);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(311, 163);
			this.Controls.Add(this.tbOpacity);
			this.Controls.Add(this.btnClose);
			this.Name = "Form1";
			this.Text = "BCIT COMP 2614";
			((System.ComponentModel.ISupportInitialize)(this.tbOpacity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TrackBar tbOpacity;
	}
}

