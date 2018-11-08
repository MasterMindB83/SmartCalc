using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCalc
{
	public partial class Form1 : Form
	{
		String sMemory="";
		String sUndo = "";
		public Form1()
		{
			InitializeComponent();
			txt_display.Text = "0|";
			txt_display.HideSelection = false;
		}

		//procedure
		public void setDisplay(String text)
		{
			if (txt_display.Text == "0|")
				txt_display.Text = text+"|";
			else
			{
				int nIndex = txt_display.Text.IndexOf("|");
				txt_display.Text=txt_display.Text.Insert(nIndex+1,text+"|");
				txt_display.Text = txt_display.Text.Remove(nIndex,1);
			}
		}
		public void EvaluateSum()
		{
			String sError = "";
			String sText = txt_display.Text.Replace("|", "");
			if (Expression.isError(sText, ref sError))
			{
				MessageBox.Show(sError, "Error");
			}
			else if (sText.Contains("X"))
			{

				MessageBox.Show("Unable to evaluate. You have variable x in expression.", "Error");
			}
			else
			{
				sUndo = txt_display.Text;
				txt_display.Text = Expression.Evaluate(txt_display.Text.Replace("|", "")) + "|";
			}
		}
		
		public void Previous()
		{
			int nIndex = txt_display.Text.IndexOf("|");
			if (nIndex > 0)
			{
				txt_display.Text = txt_display.Text.Replace("|", "");
				txt_display.Text = txt_display.Text.Insert(nIndex - 1, "|");
			}
		}
		public void Next()
		{
			int nIndex = txt_display.Text.IndexOf("|");
			if (nIndex < txt_display.Text.Length - 1)
			{
				txt_display.Text = txt_display.Text.Replace("|", "");
				txt_display.Text = txt_display.Text.Insert(nIndex + 1, "|");
			}
		}
		public void C()
		{
			int nIndex = txt_display.Text.IndexOf("|");
			txt_display.Text = txt_display.Text.Remove(nIndex - 1, 1);
			if (txt_display.Text == "|")
				txt_display.Text = "0|";
		}
		public void CE()
		{
			sUndo = txt_display.Text;
			txt_display.Text = "0|";
		}
		public void Undo()
		{

			if (sUndo != "")
				txt_display.Text = sUndo;
		}
		public void Draw()
		{

			Draw draw = new Draw(txt_display.Text.Replace("|", ""));
			draw.ShowDialog();
		}
		//eventi
		private void btn_7_Click(object sender, EventArgs e)
		{
			setDisplay("7");
		}

		private void btn_8_Click(object sender, EventArgs e)
		{
			setDisplay("8");
		}

		private void btn_9_Click(object sender, EventArgs e)
		{
			setDisplay("9");
		}

		private void btn_4_Click(object sender, EventArgs e)
		{
			setDisplay("4");
		}

		private void btn_5_Click(object sender, EventArgs e)
		{
			setDisplay("5");
		}

		private void btn_6_Click(object sender, EventArgs e)
		{
			setDisplay("6");
		}

		private void btn_1_Click(object sender, EventArgs e)
		{
			setDisplay("1");
		}

		private void btn_2_Click(object sender, EventArgs e)
		{
			setDisplay("2");
		}

		private void btn_3_Click(object sender, EventArgs e)
		{
			setDisplay("3");
		}

		private void btn_0_Click(object sender, EventArgs e)
		{
			setDisplay("0");
		}

		private void btn_exp_Click(object sender, EventArgs e)
		{
			setDisplay("e");
		}

		private void btn_tacka_Click(object sender, EventArgs e)
		{
			setDisplay(",");
		}

		private void btn_prev_Click(object sender, EventArgs e)
		{
			Previous();
		}

		private void btn_next_Click(object sender, EventArgs e)
		{

			Next();
		}

		private void btn_ozagrada_Click(object sender, EventArgs e)
		{
			setDisplay("(");
		}

		private void btn_zzagrada_Click(object sender, EventArgs e)
		{
			setDisplay(")");
		}

		private void btn_x_Click(object sender, EventArgs e)
		{
			setDisplay("X");
		}

		private void btn_sqrt_Click(object sender, EventArgs e)
		{
			setDisplay("sqrt(");
		}

		private void btn_inv_Click(object sender, EventArgs e)
		{
			if(btn_sin.Text=="sin")
			{
				btn_sin.Text = "asin";
				btn_cos.Text = "acos";
				btn_tan.Text = "atan";
			}
			else
			{
				btn_sin.Text = "sin";
				btn_cos.Text = "cos";
				btn_tan.Text = "tan";
			}
		}

		private void btn_sin_Click(object sender, EventArgs e)
		{
			setDisplay(btn_sin.Text + "(");
		}

		private void btn_cos_Click(object sender, EventArgs e)
		{
			setDisplay(btn_cos.Text + "(");
		}

		private void btn_tan_Click(object sender, EventArgs e)
		{
			setDisplay(btn_tan.Text + "(");
		}

		private void btn_c_Click(object sender, EventArgs e)
		{
			C();
		}

		private void btn_ce_Click(object sender, EventArgs e)
		{
			CE();
		}

		private void btn_plus_Click(object sender, EventArgs e)
		{
			setDisplay("+");
		}

		private void btn_minus_Click(object sender, EventArgs e)
		{
			setDisplay("-");
		}

		private void btn_puta_Click(object sender, EventArgs e)
		{
			setDisplay("*");
		}

		private void btn_podeljeno_Click(object sender, EventArgs e)
		{
			setDisplay("/");
		}

		private void btn_stepen_Click(object sender, EventArgs e)
		{
			setDisplay("^");
		}

		private void btn_jednako_Click(object sender, EventArgs e)
		{
			EvaluateSum();
		}

		private void btn_pi_Click(object sender, EventArgs e)
		{
			setDisplay("3,14159265358979");
		}

		private void btn_draw_Click(object sender, EventArgs e)
		{
			Draw();
		}

		private void btn_mem_store_Click(object sender, EventArgs e)
		{
			sMemory = txt_display.Text;
		}

		private void btn_mem_read_Click(object sender, EventArgs e)
		{
			setDisplay(sMemory);
		}

		private void btn_undo_Click(object sender, EventArgs e)
		{
			Undo();
		}
		
		

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{

			if (e.KeyCode == Keys.NumPad0)
			{
				setDisplay("0");
			}
			if (e.KeyCode == Keys.NumPad1)
			{
				setDisplay("1");
			}
			if (e.KeyCode == Keys.NumPad2)
			{
				setDisplay("2");
			}
			if (e.KeyCode == Keys.NumPad3)
			{
				setDisplay("3");
			}
			if (e.KeyCode == Keys.NumPad4)
			{
				setDisplay("4");
			}
			if (e.KeyCode == Keys.NumPad5)
			{
				setDisplay("5");
			}
			if (e.KeyCode == Keys.NumPad6)
			{
				setDisplay("6");
			}
			if (e.KeyCode == Keys.NumPad7)
			{
				setDisplay("7");
			}
			if (e.KeyCode == Keys.NumPad8)
			{
				setDisplay("8");
			}
			if (e.KeyCode == Keys.NumPad9)
			{
				setDisplay("9");
			}
			if (e.KeyCode == Keys.Add)
			{
				setDisplay("+");
			}
			if (e.KeyCode == Keys.Multiply)
			{
				setDisplay("*");
			}
			if (e.KeyCode == Keys.Divide)
			{
				setDisplay("/");
			}
			if (e.KeyCode == Keys.Subtract)
			{
				setDisplay("-");
			}
			if (e.KeyCode == Keys.Decimal)
			{
				setDisplay(",");
			}

			if (e.KeyCode == Keys.Enter)
			{
				EvaluateSum();
			}
			if (e.KeyCode == Keys.Right)
			{
				Next();
			}
			if (e.KeyCode == Keys.Left)
			{
				Previous();
			}
			if (e.KeyCode == Keys.Back)
			{
				C();
			}
			if (e.KeyCode == Keys.Delete)
			{
				CE();
			}
			if (e.KeyCode == Keys.Up)
			{
				Undo();
			}
			if (e.KeyCode == Keys.Space)
			{
				Draw();
			}
			if (e.KeyCode == Keys.Insert)
			{
				setDisplay("e");
			}

		}
	}
}
