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
	public partial class Draw : Form
	{
		public Draw(String sText)
		{
			InitializeComponent();
			txt_display.Text = sText;
		}

		private void Draw_Paint(object sender, PaintEventArgs e)
		{
			String sError = "";
			DrawCoordinate(e.Graphics);
			if (Expression.isErrorDraw(txt_display.Text, ref sError))
			{
				MessageBox.Show(sError, "Error");
			}
			else
			{
				DrawFunc(e.Graphics);
			}
		}
		
		public void DrawCoordinate(Graphics g)
		{

			Pen myPen = new Pen(Color.Black);
			int nWidth = this.Width;
			int nHeight = this.Height;
			g.DrawLine(myPen, 0, nHeight/2, nWidth, nHeight / 2);
			g.DrawLine(myPen, nWidth/2,0, nWidth/2, nHeight);
			int i = nWidth / 2;
			int j=nWidth / 2;
			int number = 0;
			Font myFont = new Font("Ariel",16);
			Brush myBrush = new SolidBrush(Color.Black);
			while(i<nWidth)
			{
				if (number % 100 == 0)
				{
					g.DrawLine(myPen, i, nHeight / 2 - 10, i, nHeight / 2 + 10);
					g.DrawLine(myPen, j, nHeight / 2 - 10, j, nHeight / 2 + 10);
				}
				else
				{
					g.DrawLine(myPen, i, nHeight / 2 - 5, i, nHeight / 2 + 5);
					g.DrawLine(myPen, j, nHeight / 2 - 5, j, nHeight / 2 + 5);
				}
				if (number%100==0)
				{
					if (number == 0)
						g.DrawString((number / 10).ToString(), myFont, myBrush, i +12, nHeight / 2 + 10);
					else
					{
						g.DrawString((number / 10).ToString(), myFont, myBrush, i - 10, nHeight / 2 + 10);
						g.DrawString((-number / 10).ToString(), myFont, myBrush, j - 15, nHeight / 2 + 10);
					}
				}
				i += 10;
				j -= 10;
				number+=10;
			}
			i = nHeight / 2;
			j = nHeight / 2;
			number = 0;
			while (i < nHeight)
			{
				if (number % 100 == 0)
				{
					g.DrawLine(myPen, nWidth / 2 - 10, i, nWidth / 2 + 10, i);
					g.DrawLine(myPen, nWidth / 2 - 10, j, nWidth / 2 + 10, j);
				}
				else
				{
					g.DrawLine(myPen, nWidth / 2 - 5, i, nWidth / 2 + 5, i);
					g.DrawLine(myPen, nWidth / 2 - 5, j, nWidth / 2 + 5, j);
				}
				if (number % 100 == 0&& number > 0)
				{
					g.DrawString((-number / 10).ToString(), myFont, myBrush, nWidth / 2 + 5, i - 12);
					g.DrawString((number / 10).ToString(), myFont, myBrush, nWidth / 2 + 5, j - 12);
					
				}
				i += 10;
				j -= 10;
				number+=10;
			}
		}
		public void DrawFunc(Graphics g)
		{
			float nWidth = this.Width;
			float nHeight = this.Height;
			Pen myPen = new Pen(Color.Blue);
			float i = 0;
			float fYPrev = 0;
			while (i < nWidth)
			{
				String sReplace = "(" + ((i - nWidth / 2) / 10).ToString() + ")";
				double dResult = Expression.Evaluate(txt_display.Text.Replace("X", sReplace));
				float fResult = nHeight / 2 - (float)dResult * 10;
				if (dResult != double.NaN)
				{
					g.DrawLine(myPen, i, fResult - 1, i, fResult + 1);
				}
				if(i>0)
				{
					for (int j = -1; j <= 1; j++)
					{
						try
						{
							g.DrawLine(myPen, i - 1, fYPrev + j, i, fResult + j);
						}
						catch(Exception ex)
						{

						}
					}
				}
				fYPrev = fResult;
				i ++;
			}
		}
		
	}
}
