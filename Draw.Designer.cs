namespace SmartCalc
{
	partial class Draw
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
			this.txt_display = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txt_display
			// 
			this.txt_display.Enabled = false;
			this.txt_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_display.Location = new System.Drawing.Point(12, 2);
			this.txt_display.Name = "txt_display";
			this.txt_display.Size = new System.Drawing.Size(1058, 22);
			this.txt_display.TabIndex = 0;
			// 
			// Draw
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1082, 732);
			this.Controls.Add(this.txt_display);
			this.Name = "Draw";
			this.Text = "Draw";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw_Paint);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_display;
	}
}