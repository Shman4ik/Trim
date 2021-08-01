using System;

namespace Trim
{
	class Program
	{
		static void Main(string[] args)
		{
			var str = "On__my___home_world";
			var result = RemoveSpace(str);
			Console.WriteLine(result);
			Console.ReadLine();
		}

		private static string RemoveSpace(string str)
		{
			var strArray = str.ToCharArray();
			var lastNotSpace = 0;
			var i = 0;
			do
			{
				if (IsSpace(strArray[i]))
				{
					if (i + 1 < strArray.Length)
					{
						if (IsSpace(strArray[i + 1]))
						{
							i++;
						}
						else
						{
							strArray[lastNotSpace + 2] = strArray[i + 1];
							lastNotSpace += 2;
							strArray[i + 1] = ' ';
							i++;
						}
					}
					else
					{
						break;
					}
				}
				else
				{
					lastNotSpace = i;
					i++;
				}
			} while (i < strArray.Length);
			return strArray.ToString(); ;
		}

		private static bool IsSpace(char letter)
		{
			return letter == ' ' || letter == '_';
		}

		//before: _On__my___home_world
		//after:  On_my_home_world
	}
}
