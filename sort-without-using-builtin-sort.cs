using System;
					
public class Program
{
	public static void Main()
	{ 
		
		int[] givenIntegers = new int[]{1,2,10,99,5,8,70};
		int[] sorted = new int[givenIntegers.Length]; 
		int currentValue = 0;
		 
		for(int i=0; i<givenIntegers.Length; i++)
		{
			for(int f=i+1; f<givenIntegers.Length; f++)
			{
				//check if current first loop value is greater than the inner loop current index value
				if(givenIntegers[i] > givenIntegers[f])
				{
					currentValue = givenIntegers[i];  //get the current index value for swap purpose.
					
					//swap index value. 
					givenIntegers[i] = givenIntegers[f];  
                    givenIntegers[f] = currentValue; 
				}
			}
		}
		
		foreach(int intValue in givenIntegers){
			Console.WriteLine(intValue);
		}
	}
}
