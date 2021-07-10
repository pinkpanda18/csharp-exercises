using System;
					
public class Program
{
	public static void Main()
	{ 	
		IsPalindrome("madam");
	}
	
	private static bool IsPalindrome(string word) {	
		bool r =  word.ToUpper() == ReverseString(word.ToUpper());
		if(r) {
			Console.WriteLine("Yes, its palindrome");
			return true;
		}
		Console.WriteLine("No, its not a palindrome");
		return false;
	}
		   
	private static string ReverseString(string myName){

		string reverseName = "";
		for(int i = myName.Length-1; i >= 0; i--){		 
			reverseName+=myName[i];
		}

		Console.WriteLine(reverseName);
		return reverseName;
	
	}
	
	
}
