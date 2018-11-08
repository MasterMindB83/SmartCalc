using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCalc
{
	static class Expression
	{
		public static double Evaluate(String sText)
		{
			String sFunc = "sincotasqrt";
			sText = sText.Replace("E", "e");
		if (sText == "NaN")
			return double.NaN;
			if (sText.Substring(0, 1) == "-")
			{
				if (sText.Substring(1, 1) == "(" || sFunc.Contains(sText.Substring(1, 1)))
					sText = "0" + sText;
			}
			double result = 0;
		try
		{
			String[] sNiz = new String[100];
			int nNo = 0;
			String sName = "";//za funkciju
			String sOperand = "";
			if (sText == "" || sText == null)
				return result;
			while (sText.Substring(0, 1) == "(")// na pr (3+2)
			{
				String sPom = sText.Substring(0, sText.Length);
				int nOpenBrackets = 0;
				bool bIsDoubleBrackets = true;
				for (int i = 0; i < sPom.Length; i++)
				{
					String currChar = sPom.Substring(i, 1);// tekuci karakter
					if (currChar == "(")//ako je nadjena otvorena zagrada
						nOpenBrackets++;
					else if (currChar == ")")//ako je nadjena zatvorena zagrada
						nOpenBrackets--;
					if (nOpenBrackets < 0)
					{
						bIsDoubleBrackets = false;
					}
					else if (nOpenBrackets == 0 && i < sPom.Length - 1)
					{
						bIsDoubleBrackets = false;
					}
				}
				if (nOpenBrackets != 0)//ako ima nezatvorenih otvorenih zagrada
				{
					bIsDoubleBrackets = false;
				}
				if (bIsDoubleBrackets && sText.Substring(sText.Length - 1, 1) == ")")
				{
					sText = sPom.Substring(1, sPom.Length - 2);
				}
				else
				{
					break;
				}
			}
			if (isNumber(sText))
			{
				return double.Parse(sText);
			}
			else if (GetFunc(sText, ref sName, ref sOperand))
			{
				return Calculate(0, sName, Evaluate(sOperand));
			}
			else
			{


				int nPos = 0;
				while (nPos < sText.Length)
				{
					sNiz[nNo++] = GetItem(sText, ref nPos);
				}
				while (nNo >= 1)
				{
					if (nNo == 1)
					{
						nNo = 0;
						return Evaluate(sNiz[0]);
					}
					else
					{
						int nCurrOperand = 0;
						//return Calculate(Evaluate(sOperand1), sOperacija, Evaluate(sOperand2));
						while (!Priority(sNiz[nCurrOperand + 1], sNiz[nCurrOperand + 3]))
							nCurrOperand += 2;
						sNiz[nCurrOperand] = Calculate(Evaluate(sNiz[nCurrOperand]), sNiz[nCurrOperand + 1], Evaluate(sNiz[nCurrOperand + 2])).ToString();
						for (int i = nCurrOperand + 1; i < nNo; i++)
						{
							sNiz[i] = sNiz[i + 2];
						}
						nNo = nNo - 2;
					}
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Error");
		}
		return result;


	}
	public static bool GetFunc(String sText, ref String sName, ref String sOperand)
	{
		String sFunc = "sincotasqrt";
		bool bFound = false;
		foreach (char currChar in sFunc)
		{
			if (sText.Substring(0, 1) == currChar.ToString())
			{
				bFound = true;
				break;
			}
		}
		if (bFound)
		{
			int nEnd = 0;
			for (int i = 0; i < sText.Length; i++)
			{
				if (sFunc.Contains(sText.Substring(i, 1)))
					nEnd = i;
				else
					break;
			}
			nEnd++;
			sName = sText.Substring(0, nEnd);
			int nStart = nEnd;
			int nOpenBrackets = 0;
			for (int i = nStart; i < sText.Length; i++)
			{
				if (sText.Substring(i, 1) == "(")
					nOpenBrackets++;
				else if (sText.Substring(i, 1) == ")")
					nOpenBrackets--;
				if (nOpenBrackets == 0)
				{
					if (i < sText.Length - 1)
						return false;
				}
			}
			sOperand = sText.Substring(nStart + 1, sText.Length - nStart - 2);
			return true;

		}
		else
		{
			return false;
		}
	}
	public static bool Priority(String sOPeracija1, String sOperacija2)
	{
		if (PriorityNumber(sOperacija2) > PriorityNumber(sOPeracija1))
			return false;
		else if (PriorityNumber(sOperacija2) == PriorityNumber(sOPeracija1) && PriorityNumber(sOperacija2) == 3)
			return false;
		else
			return true;
	}
	public static int PriorityNumber(String sOperacija)
	{
		if (sOperacija == "+" || sOperacija == "-")
			return 1;
		else if (sOperacija == "*" || sOperacija == "/")
			return 2;
		else if (sOperacija == "^")
			return 3;
		return -1;
	}
	public static double Calculate(double nOperand1, String sOPeracija, double nOperand2)
	{
		double result = 0;
		if (sOPeracija == "+")
			result = nOperand1 + nOperand2;
		else if (sOPeracija == "-")
			result = nOperand1 - nOperand2;
		else if (sOPeracija == "*")
			result = nOperand1 * nOperand2;
		else if (sOPeracija == "^")
			result = Math.Pow(nOperand1, nOperand2);
		else if (sOPeracija == "/")
			result = nOperand1 / nOperand2;
		else if (sOPeracija == "sin")
			result = Math.Sin(nOperand2);
		else if (sOPeracija == "cos")
			result = Math.Cos(nOperand2);
		else if (sOPeracija == "tan")
			result = Math.Tan(nOperand2);
		else if (sOPeracija == "asin")
			result = Math.Asin(nOperand2);
		else if (sOPeracija == "acos")
			result = Math.Acos(nOperand2);
		else if (sOPeracija == "atan")
			result = Math.Atan(nOperand2);
		else if (sOPeracija == "sqrt")
			result = Math.Sqrt(nOperand2);

		return result;
	}
	public static bool isNumber(String sText)
	{
		bool bReturn = true;
		for (int i = 0; i < sText.Length; i++)
		{
			String currChar = sText.Substring(i, 1);
			String sNumbers = "01234567890";
			bool bFound = false;
			for (int j = 0; j < sNumbers.Length; j++)
			{
				if (currChar == sNumbers.Substring(j, 1))
				{
					bFound = true;
					break;
				}
			}
			if (currChar == "-" && i == 0)//negativni broj
				continue;
			else if (i > 0 && currChar == "-" && sText.Substring(i - 1, 1) == "e")
				continue;
			else if (currChar == "e")
				continue;
			else if (currChar == ",")
				continue;
			else if (bFound)
				continue;
			else if (i > 0 && currChar == "+" && sText.Substring(i - 1, 1) == "e")
				continue;
			else
			{
				bReturn = false;
				break;
			}
		}
		return bReturn;
	}
	public static String GetItem(String sText, ref int nPos)
	{
		String sResult = "";
		if (sText == null || nPos > sText.Length - 1)
			return "";
		int nStart = nPos;
		String sFunc = "sincotasqrt";
		int nOpenBrackets = 0;
		String currChar = sText.Substring(nPos, 1);
		bool bFound = false;
		foreach (char currCharacter in sFunc)
		{
			if (sText.Substring(nPos, 1) == currCharacter.ToString())
			{
				bFound = true;
				break;
			}
		}
		if (bFound)
		{
			while (sFunc.Contains(currChar))
			{
				currChar = sText.Substring(nPos, 1);
				nPos++;
			}
			nOpenBrackets = 1;
			while (nOpenBrackets != 0)
			{
				currChar = sText.Substring(nPos, 1);
				if (currChar == "(")
					nOpenBrackets++;
				else if (currChar == ")")
					nOpenBrackets--;
				nPos++;
			}
			sResult = sText.Substring(nStart, nPos - nStart);

		}
		else if (currChar == "(")
		{
			nOpenBrackets = 1;
			nStart = nPos + 1;
			for (int i = nStart; i < sText.Length; i++)
			{
				currChar = sText.Substring(i, 1);
				if (currChar == "(")
					nOpenBrackets++;
				else if (currChar == ")")
					nOpenBrackets--;
				if (nOpenBrackets == 0)
				{
					nPos = i + 1;
					break;
				}
			}
			return sText.Substring(nStart, nPos - nStart - 1);
		}
		else if (IsCifra(sText, ref nPos))
		{
			while (IsCifra(sText, ref nPos) && nPos < sText.Length)
			{
				//currChar = sText.Substring(nPos, 1);
				nPos++;
			}
			sResult = sText.Substring(nStart, nPos - nStart);
		}
		else
		{
			sResult = currChar;
			nPos++;
		}
		return sResult;

	}

	public static bool isError(String sText, ref String sError)
	{
		int nOpenBrackets = 0;
		bool bError = false;
		sError = "You have unclosed brackets.";
		for (int i = 0; i < sText.Length; i++)
		{
			String currChar = sText.Substring(i, 1);// tekuci karakter
			String sOperacije = "/*-+^";
			if (currChar == "(")//ako je nadjena otvorena zagrada
				nOpenBrackets++;
			else if (currChar == ")")//ako je nadjena zatvorena zagrada
			{
				nOpenBrackets--;
				if (i > 0 && sText.Substring(i - 1, 1) == "(")
				{
					bError = true;
					sError = "You have missing argument.";
					break;
				}
				else if (i == 0)
				{
					bError = true;
					sError = "Expression can not start with closed bracket.";
					break;
				}
			}
			if (nOpenBrackets < 0)
			{
				bError = true;
				sError = "You have more closing brackets.";
				break;
			}
			if (i > 0)
			{
				if (sOperacije.Contains(sText.Substring(i - 1, 1)) && sOperacije.Contains(sText.Substring(i, 1)))
				{
					bError = true;
					sError = "Error in expression.";
				}
			}
			else if (sOperacije.Contains(sText.Substring(0, 1)) && sText.Substring(0, 1) != "-")
			{
				bError = true;
				sError = "Expression can not start with operation.";

			}
			if (sText.Contains("X"))
			{
				bError = true;
				sError = "Unable to evaluate expression. You have variable x.";
			}
		}
		return bError;
	}
		public static bool isErrorDraw(String sText, ref String sError)
		{
			int nOpenBrackets = 0;
			bool bError = false;
			sError = "You have unclosed brackets.";
			for (int i = 0; i < sText.Length; i++)
			{
				String currChar = sText.Substring(i, 1);// tekuci karakter
				String sOperacije = "/*-+^";
				if (currChar == "(")//ako je nadjena otvorena zagrada
					nOpenBrackets++;
				else if (currChar == ")")//ako je nadjena zatvorena zagrada
				{
					nOpenBrackets--;
					if (i > 0 && sText.Substring(i - 1, 1) == "(")
					{
						bError = true;
						sError = "You have missing argument.";
						break;
					}
					else if (i == 0)
					{
						bError = true;
						sError = "Expression can not start with closed bracket.";
						break;
					}
				}
				if (nOpenBrackets < 0)
				{
					bError = true;
					sError = "You have more closing brackets.";
					break;
				}
				if (i > 0)
				{
					if (sOperacije.Contains(sText.Substring(i - 1, 1)) && sOperacije.Contains(sText.Substring(i, 1)))
					{
						bError = true;
						sError = "Error in expression.";
					}
				}
				else if (sOperacije.Contains(sText.Substring(i, 1)))
				{
					sError = "Expression can not start with operation.";

				}
			}
			return bError;
		}
		public static bool IsCifra(String sText, ref int nPos)
	{
		if (sText == null)
			return false;
		if (nPos > sText.Length - 1)
			return false;
		bool bReturn = false;
		String currChar = sText.Substring(nPos, 1);
		String sNumbers = "01234567890";
		if (currChar == "-" && (nPos == 0 || sText.Substring(nPos - 1, 1) == "("))//negativni broj
			bReturn = true;
		else if (nPos > 0 && currChar == "-" && sText.Substring(nPos - 1, 1) == "e")
			bReturn = true;
		else if (nPos > 0 && currChar == "+" && sText.Substring(nPos - 1, 1) == "e")
			bReturn = true;
		else if (sNumbers.Contains(currChar))
			bReturn = true;
		else if (currChar == "e")
			bReturn = true;
		else if (currChar == ",")
			bReturn = true;
		else
			bReturn = false;
		return bReturn;
	}
}
}
