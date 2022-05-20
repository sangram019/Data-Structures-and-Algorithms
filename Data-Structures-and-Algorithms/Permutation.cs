﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Permutation
{
	private static void permute(String str,int l, int r)
	{
		if (l == r)
			Console.WriteLine(str);
		else
		{
			for (int i = l; i <= r; i++)
			{
				str = swap(str, l, i);
				permute(str, l + 1, r);
				str = swap(str, l, i);
			}
		}
	}

	public static String swap(String a,int i, int j)
	{
		char temp;
		char[] charArray = a.ToCharArray();
		temp = charArray[i];
		charArray[i] = charArray[j];
		charArray[j] = temp;
		string s = new string(charArray);
		return s;
	}

public static void Main()
{
    String str = "ABC";
    int n = str.Length;
    permute(str, 0, n - 1);
}
}

