namespace SmartCalc
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.txt_display = new System.Windows.Forms.TextBox();
			this.btn_next = new System.Windows.Forms.Button();
			this.btn_prev = new System.Windows.Forms.Button();
			this.btn_undo = new System.Windows.Forms.Button();
			this.btn_draw = new System.Windows.Forms.Button();
			this.btn_mem_store = new System.Windows.Forms.Button();
			this.btn_ce = new System.Windows.Forms.Button();
			this.btn_c = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_stepen = new System.Windows.Forms.Button();
			this.btn_jednako = new System.Windows.Forms.Button();
			this.btn_plus = new System.Windows.Forms.Button();
			this.btn_minus = new System.Windows.Forms.Button();
			this.btn_podeljeno = new System.Windows.Forms.Button();
			this.btn_puta = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btn_tan = new System.Windows.Forms.Button();
			this.btn_pi = new System.Windows.Forms.Button();
			this.btn_x = new System.Windows.Forms.Button();
			this.btn_cos = new System.Windows.Forms.Button();
			this.btn_inv = new System.Windows.Forms.Button();
			this.btn_zzagrada = new System.Windows.Forms.Button();
			this.btn_sin = new System.Windows.Forms.Button();
			this.btn_sqrt = new System.Windows.Forms.Button();
			this.btn_ozagrada = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btn_tacka = new System.Windows.Forms.Button();
			this.btn_0 = new System.Windows.Forms.Button();
			this.btn_exp = new System.Windows.Forms.Button();
			this.btn_3 = new System.Windows.Forms.Button();
			this.btn_2 = new System.Windows.Forms.Button();
			this.btn_1 = new System.Windows.Forms.Button();
			this.btn_6 = new System.Windows.Forms.Button();
			this.btn_5 = new System.Windows.Forms.Button();
			this.btn_4 = new System.Windows.Forms.Button();
			this.btn_9 = new System.Windows.Forms.Button();
			this.btn_8 = new System.Windows.Forms.Button();
			this.btn_7 = new System.Windows.Forms.Button();
			this.btn_mem_read = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// txt_display
			// 
			this.txt_display.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_display.Location = new System.Drawing.Point(12, 12);
			this.txt_display.Name = "txt_display";
			this.txt_display.ReadOnly = true;
			this.txt_display.Size = new System.Drawing.Size(474, 22);
			this.txt_display.TabIndex = 0;
			this.txt_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btn_next
			// 
			this.btn_next.Location = new System.Drawing.Point(116, 40);
			this.btn_next.Name = "btn_next";
			this.btn_next.Size = new System.Drawing.Size(48, 23);
			this.btn_next.TabIndex = 15;
			this.btn_next.Text = "-->";
			this.btn_next.UseVisualStyleBackColor = true;
			this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
			// 
			// btn_prev
			// 
			this.btn_prev.Location = new System.Drawing.Point(64, 40);
			this.btn_prev.Name = "btn_prev";
			this.btn_prev.Size = new System.Drawing.Size(46, 23);
			this.btn_prev.TabIndex = 14;
			this.btn_prev.Text = "<--";
			this.btn_prev.UseVisualStyleBackColor = true;
			this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
			// 
			// btn_undo
			// 
			this.btn_undo.Location = new System.Drawing.Point(11, 40);
			this.btn_undo.Name = "btn_undo";
			this.btn_undo.Size = new System.Drawing.Size(50, 23);
			this.btn_undo.TabIndex = 13;
			this.btn_undo.Text = "Undo";
			this.btn_undo.UseVisualStyleBackColor = true;
			this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
			// 
			// btn_draw
			// 
			this.btn_draw.Location = new System.Drawing.Point(185, 40);
			this.btn_draw.Name = "btn_draw";
			this.btn_draw.Size = new System.Drawing.Size(50, 23);
			this.btn_draw.TabIndex = 16;
			this.btn_draw.Text = "Draw";
			this.btn_draw.UseVisualStyleBackColor = true;
			this.btn_draw.Click += new System.EventHandler(this.btn_draw_Click);
			// 
			// btn_mem_store
			// 
			this.btn_mem_store.Location = new System.Drawing.Point(241, 40);
			this.btn_mem_store.Name = "btn_mem_store";
			this.btn_mem_store.Size = new System.Drawing.Size(50, 23);
			this.btn_mem_store.TabIndex = 17;
			this.btn_mem_store.Text = "MS";
			this.btn_mem_store.UseVisualStyleBackColor = true;
			this.btn_mem_store.Click += new System.EventHandler(this.btn_mem_store_Click);
			// 
			// btn_ce
			// 
			this.btn_ce.Location = new System.Drawing.Point(421, 40);
			this.btn_ce.Name = "btn_ce";
			this.btn_ce.Size = new System.Drawing.Size(50, 23);
			this.btn_ce.TabIndex = 33;
			this.btn_ce.Text = "CE";
			this.btn_ce.UseVisualStyleBackColor = true;
			this.btn_ce.Click += new System.EventHandler(this.btn_ce_Click);
			// 
			// btn_c
			// 
			this.btn_c.Location = new System.Drawing.Point(366, 40);
			this.btn_c.Name = "btn_c";
			this.btn_c.Size = new System.Drawing.Size(50, 23);
			this.btn_c.TabIndex = 32;
			this.btn_c.Text = "C";
			this.btn_c.UseVisualStyleBackColor = true;
			this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_stepen);
			this.panel1.Controls.Add(this.btn_jednako);
			this.panel1.Controls.Add(this.btn_plus);
			this.panel1.Controls.Add(this.btn_minus);
			this.panel1.Controls.Add(this.btn_podeljeno);
			this.panel1.Controls.Add(this.btn_puta);
			this.panel1.Location = new System.Drawing.Point(364, 78);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(119, 141);
			this.panel1.TabIndex = 34;
			// 
			// btn_stepen
			// 
			this.btn_stepen.Location = new System.Drawing.Point(58, 14);
			this.btn_stepen.Name = "btn_stepen";
			this.btn_stepen.Size = new System.Drawing.Size(49, 23);
			this.btn_stepen.TabIndex = 39;
			this.btn_stepen.Text = "^";
			this.btn_stepen.UseVisualStyleBackColor = true;
			this.btn_stepen.Click += new System.EventHandler(this.btn_stepen_Click);
			// 
			// btn_jednako
			// 
			this.btn_jednako.Location = new System.Drawing.Point(58, 43);
			this.btn_jednako.Name = "btn_jednako";
			this.btn_jednako.Size = new System.Drawing.Size(49, 81);
			this.btn_jednako.TabIndex = 40;
			this.btn_jednako.Text = "=";
			this.btn_jednako.UseVisualStyleBackColor = true;
			this.btn_jednako.Click += new System.EventHandler(this.btn_jednako_Click);
			// 
			// btn_plus
			// 
			this.btn_plus.Location = new System.Drawing.Point(3, 14);
			this.btn_plus.Name = "btn_plus";
			this.btn_plus.Size = new System.Drawing.Size(49, 23);
			this.btn_plus.TabIndex = 35;
			this.btn_plus.Text = "+";
			this.btn_plus.UseVisualStyleBackColor = true;
			this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
			// 
			// btn_minus
			// 
			this.btn_minus.Location = new System.Drawing.Point(3, 43);
			this.btn_minus.Name = "btn_minus";
			this.btn_minus.Size = new System.Drawing.Size(49, 23);
			this.btn_minus.TabIndex = 36;
			this.btn_minus.Text = "-";
			this.btn_minus.UseVisualStyleBackColor = true;
			this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
			// 
			// btn_podeljeno
			// 
			this.btn_podeljeno.Location = new System.Drawing.Point(3, 101);
			this.btn_podeljeno.Name = "btn_podeljeno";
			this.btn_podeljeno.Size = new System.Drawing.Size(49, 23);
			this.btn_podeljeno.TabIndex = 38;
			this.btn_podeljeno.Text = "/";
			this.btn_podeljeno.UseVisualStyleBackColor = true;
			this.btn_podeljeno.Click += new System.EventHandler(this.btn_podeljeno_Click);
			// 
			// btn_puta
			// 
			this.btn_puta.Location = new System.Drawing.Point(3, 72);
			this.btn_puta.Name = "btn_puta";
			this.btn_puta.Size = new System.Drawing.Size(49, 23);
			this.btn_puta.TabIndex = 37;
			this.btn_puta.Text = "*";
			this.btn_puta.UseVisualStyleBackColor = true;
			this.btn_puta.Click += new System.EventHandler(this.btn_puta_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btn_tan);
			this.panel2.Controls.Add(this.btn_pi);
			this.panel2.Controls.Add(this.btn_x);
			this.panel2.Controls.Add(this.btn_cos);
			this.panel2.Controls.Add(this.btn_inv);
			this.panel2.Controls.Add(this.btn_zzagrada);
			this.panel2.Controls.Add(this.btn_sin);
			this.panel2.Controls.Add(this.btn_sqrt);
			this.panel2.Controls.Add(this.btn_ozagrada);
			this.panel2.Location = new System.Drawing.Point(182, 78);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(176, 141);
			this.panel2.TabIndex = 39;
			// 
			// btn_tan
			// 
			this.btn_tan.Location = new System.Drawing.Point(113, 72);
			this.btn_tan.Name = "btn_tan";
			this.btn_tan.Size = new System.Drawing.Size(49, 23);
			this.btn_tan.TabIndex = 49;
			this.btn_tan.Text = "tan";
			this.btn_tan.UseVisualStyleBackColor = true;
			this.btn_tan.Click += new System.EventHandler(this.btn_tan_Click);
			// 
			// btn_pi
			// 
			this.btn_pi.Location = new System.Drawing.Point(113, 43);
			this.btn_pi.Name = "btn_pi";
			this.btn_pi.Size = new System.Drawing.Size(49, 23);
			this.btn_pi.TabIndex = 48;
			this.btn_pi.Text = "Pi";
			this.btn_pi.UseVisualStyleBackColor = true;
			this.btn_pi.Click += new System.EventHandler(this.btn_pi_Click);
			// 
			// btn_x
			// 
			this.btn_x.Location = new System.Drawing.Point(113, 14);
			this.btn_x.Name = "btn_x";
			this.btn_x.Size = new System.Drawing.Size(49, 23);
			this.btn_x.TabIndex = 47;
			this.btn_x.Text = "X";
			this.btn_x.UseVisualStyleBackColor = true;
			this.btn_x.Click += new System.EventHandler(this.btn_x_Click);
			// 
			// btn_cos
			// 
			this.btn_cos.Location = new System.Drawing.Point(58, 72);
			this.btn_cos.Name = "btn_cos";
			this.btn_cos.Size = new System.Drawing.Size(49, 23);
			this.btn_cos.TabIndex = 45;
			this.btn_cos.Text = "cos";
			this.btn_cos.UseVisualStyleBackColor = true;
			this.btn_cos.Click += new System.EventHandler(this.btn_cos_Click);
			// 
			// btn_inv
			// 
			this.btn_inv.Location = new System.Drawing.Point(58, 43);
			this.btn_inv.Name = "btn_inv";
			this.btn_inv.Size = new System.Drawing.Size(49, 23);
			this.btn_inv.TabIndex = 44;
			this.btn_inv.Text = "inv";
			this.btn_inv.UseVisualStyleBackColor = true;
			this.btn_inv.Click += new System.EventHandler(this.btn_inv_Click);
			// 
			// btn_zzagrada
			// 
			this.btn_zzagrada.Location = new System.Drawing.Point(58, 14);
			this.btn_zzagrada.Name = "btn_zzagrada";
			this.btn_zzagrada.Size = new System.Drawing.Size(49, 23);
			this.btn_zzagrada.TabIndex = 43;
			this.btn_zzagrada.Text = ")";
			this.btn_zzagrada.UseVisualStyleBackColor = true;
			this.btn_zzagrada.Click += new System.EventHandler(this.btn_zzagrada_Click);
			// 
			// btn_sin
			// 
			this.btn_sin.Location = new System.Drawing.Point(3, 72);
			this.btn_sin.Name = "btn_sin";
			this.btn_sin.Size = new System.Drawing.Size(49, 23);
			this.btn_sin.TabIndex = 41;
			this.btn_sin.Text = "sin";
			this.btn_sin.UseVisualStyleBackColor = true;
			this.btn_sin.Click += new System.EventHandler(this.btn_sin_Click);
			// 
			// btn_sqrt
			// 
			this.btn_sqrt.Location = new System.Drawing.Point(3, 43);
			this.btn_sqrt.Name = "btn_sqrt";
			this.btn_sqrt.Size = new System.Drawing.Size(49, 23);
			this.btn_sqrt.TabIndex = 40;
			this.btn_sqrt.Text = "sqrt";
			this.btn_sqrt.UseVisualStyleBackColor = true;
			this.btn_sqrt.Click += new System.EventHandler(this.btn_sqrt_Click);
			// 
			// btn_ozagrada
			// 
			this.btn_ozagrada.Location = new System.Drawing.Point(3, 14);
			this.btn_ozagrada.Name = "btn_ozagrada";
			this.btn_ozagrada.Size = new System.Drawing.Size(49, 23);
			this.btn_ozagrada.TabIndex = 39;
			this.btn_ozagrada.Text = "(";
			this.btn_ozagrada.UseVisualStyleBackColor = true;
			this.btn_ozagrada.Click += new System.EventHandler(this.btn_ozagrada_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btn_tacka);
			this.panel3.Controls.Add(this.btn_0);
			this.panel3.Controls.Add(this.btn_exp);
			this.panel3.Controls.Add(this.btn_3);
			this.panel3.Controls.Add(this.btn_2);
			this.panel3.Controls.Add(this.btn_1);
			this.panel3.Controls.Add(this.btn_6);
			this.panel3.Controls.Add(this.btn_5);
			this.panel3.Controls.Add(this.btn_4);
			this.panel3.Controls.Add(this.btn_9);
			this.panel3.Controls.Add(this.btn_8);
			this.panel3.Controls.Add(this.btn_7);
			this.panel3.Location = new System.Drawing.Point(11, 78);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(165, 141);
			this.panel3.TabIndex = 40;
			// 
			// btn_tacka
			// 
			this.btn_tacka.Location = new System.Drawing.Point(105, 101);
			this.btn_tacka.Name = "btn_tacka";
			this.btn_tacka.Size = new System.Drawing.Size(49, 23);
			this.btn_tacka.TabIndex = 24;
			this.btn_tacka.Text = ",";
			this.btn_tacka.UseVisualStyleBackColor = true;
			this.btn_tacka.Click += new System.EventHandler(this.btn_tacka_Click);
			// 
			// btn_0
			// 
			this.btn_0.Location = new System.Drawing.Point(53, 101);
			this.btn_0.Name = "btn_0";
			this.btn_0.Size = new System.Drawing.Size(49, 23);
			this.btn_0.TabIndex = 23;
			this.btn_0.Text = "0";
			this.btn_0.UseVisualStyleBackColor = true;
			this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
			// 
			// btn_exp
			// 
			this.btn_exp.Location = new System.Drawing.Point(3, 101);
			this.btn_exp.Name = "btn_exp";
			this.btn_exp.Size = new System.Drawing.Size(50, 23);
			this.btn_exp.TabIndex = 22;
			this.btn_exp.Text = "Exp";
			this.btn_exp.UseVisualStyleBackColor = true;
			this.btn_exp.Click += new System.EventHandler(this.btn_exp_Click);
			// 
			// btn_3
			// 
			this.btn_3.Location = new System.Drawing.Point(105, 72);
			this.btn_3.Name = "btn_3";
			this.btn_3.Size = new System.Drawing.Size(49, 23);
			this.btn_3.TabIndex = 21;
			this.btn_3.Text = "3";
			this.btn_3.UseVisualStyleBackColor = true;
			this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
			// 
			// btn_2
			// 
			this.btn_2.Location = new System.Drawing.Point(53, 72);
			this.btn_2.Name = "btn_2";
			this.btn_2.Size = new System.Drawing.Size(49, 23);
			this.btn_2.TabIndex = 20;
			this.btn_2.Text = "2";
			this.btn_2.UseVisualStyleBackColor = true;
			this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
			// 
			// btn_1
			// 
			this.btn_1.Location = new System.Drawing.Point(3, 72);
			this.btn_1.Name = "btn_1";
			this.btn_1.Size = new System.Drawing.Size(50, 23);
			this.btn_1.TabIndex = 19;
			this.btn_1.Text = "1";
			this.btn_1.UseVisualStyleBackColor = true;
			this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
			// 
			// btn_6
			// 
			this.btn_6.Location = new System.Drawing.Point(104, 43);
			this.btn_6.Name = "btn_6";
			this.btn_6.Size = new System.Drawing.Size(49, 23);
			this.btn_6.TabIndex = 18;
			this.btn_6.Text = "6";
			this.btn_6.UseVisualStyleBackColor = true;
			this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
			// 
			// btn_5
			// 
			this.btn_5.Location = new System.Drawing.Point(53, 43);
			this.btn_5.Name = "btn_5";
			this.btn_5.Size = new System.Drawing.Size(49, 23);
			this.btn_5.TabIndex = 17;
			this.btn_5.Text = "5";
			this.btn_5.UseVisualStyleBackColor = true;
			this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
			// 
			// btn_4
			// 
			this.btn_4.Location = new System.Drawing.Point(3, 43);
			this.btn_4.Name = "btn_4";
			this.btn_4.Size = new System.Drawing.Size(50, 23);
			this.btn_4.TabIndex = 16;
			this.btn_4.Text = "4";
			this.btn_4.UseVisualStyleBackColor = true;
			this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
			// 
			// btn_9
			// 
			this.btn_9.Location = new System.Drawing.Point(105, 14);
			this.btn_9.Name = "btn_9";
			this.btn_9.Size = new System.Drawing.Size(49, 23);
			this.btn_9.TabIndex = 15;
			this.btn_9.Text = "9";
			this.btn_9.UseVisualStyleBackColor = true;
			this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
			// 
			// btn_8
			// 
			this.btn_8.Location = new System.Drawing.Point(53, 14);
			this.btn_8.Name = "btn_8";
			this.btn_8.Size = new System.Drawing.Size(49, 23);
			this.btn_8.TabIndex = 14;
			this.btn_8.Text = "8";
			this.btn_8.UseVisualStyleBackColor = true;
			this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
			// 
			// btn_7
			// 
			this.btn_7.Location = new System.Drawing.Point(3, 14);
			this.btn_7.Name = "btn_7";
			this.btn_7.Size = new System.Drawing.Size(50, 23);
			this.btn_7.TabIndex = 13;
			this.btn_7.Text = "7";
			this.btn_7.UseVisualStyleBackColor = true;
			this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
			// 
			// btn_mem_read
			// 
			this.btn_mem_read.Location = new System.Drawing.Point(297, 40);
			this.btn_mem_read.Name = "btn_mem_read";
			this.btn_mem_read.Size = new System.Drawing.Size(50, 23);
			this.btn_mem_read.TabIndex = 41;
			this.btn_mem_read.Text = "MR";
			this.btn_mem_read.UseVisualStyleBackColor = true;
			this.btn_mem_read.Click += new System.EventHandler(this.btn_mem_read_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(498, 237);
			this.Controls.Add(this.btn_mem_read);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_ce);
			this.Controls.Add(this.btn_c);
			this.Controls.Add(this.btn_mem_store);
			this.Controls.Add(this.btn_draw);
			this.Controls.Add(this.btn_next);
			this.Controls.Add(this.btn_prev);
			this.Controls.Add(this.btn_undo);
			this.Controls.Add(this.txt_display);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "SmartCalc 2.0";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_display;
		private System.Windows.Forms.Button btn_next;
		private System.Windows.Forms.Button btn_prev;
		private System.Windows.Forms.Button btn_undo;
		private System.Windows.Forms.Button btn_draw;
		private System.Windows.Forms.Button btn_mem_store;
		private System.Windows.Forms.Button btn_ce;
		private System.Windows.Forms.Button btn_c;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_stepen;
		private System.Windows.Forms.Button btn_jednako;
		private System.Windows.Forms.Button btn_plus;
		private System.Windows.Forms.Button btn_minus;
		private System.Windows.Forms.Button btn_podeljeno;
		private System.Windows.Forms.Button btn_puta;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btn_tan;
		private System.Windows.Forms.Button btn_pi;
		private System.Windows.Forms.Button btn_x;
		private System.Windows.Forms.Button btn_cos;
		private System.Windows.Forms.Button btn_inv;
		private System.Windows.Forms.Button btn_zzagrada;
		private System.Windows.Forms.Button btn_sin;
		private System.Windows.Forms.Button btn_sqrt;
		private System.Windows.Forms.Button btn_ozagrada;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btn_tacka;
		private System.Windows.Forms.Button btn_0;
		private System.Windows.Forms.Button btn_exp;
		private System.Windows.Forms.Button btn_3;
		private System.Windows.Forms.Button btn_2;
		private System.Windows.Forms.Button btn_1;
		private System.Windows.Forms.Button btn_6;
		private System.Windows.Forms.Button btn_5;
		private System.Windows.Forms.Button btn_4;
		private System.Windows.Forms.Button btn_9;
		private System.Windows.Forms.Button btn_8;
		private System.Windows.Forms.Button btn_7;
		private System.Windows.Forms.Button btn_mem_read;
	}
}

