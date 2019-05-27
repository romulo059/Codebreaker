using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBreaker
{
	public class Game
	{
		int position;
		int longitud = 4;

		public string GetResultGame(string code, string password)
		{
			position = 0;
			return resultGame(code, password);
		}

		private string resultGame(string code, string password)
		{
			if (position == longitud - 1)
			{
				return returnValue(code, password);
			}
			else
			{
				string value = returnValue(code, password);
				position++;
				return ordenarResult(value, resultGame(code, password));
			}
		}

		private string returnValue(string code, string password)
		{
			if ((code[position] == password[position]))
			{
				return "X";
			}
			else if (password.Contains(code[position]))
			{
				return "*";
			}
			else
			{
				return "";
			}
		}

		private string ordenarResult(string value, string password)
		{
			return (value == "*") ? password + value : value + password;
		}
	}
}
