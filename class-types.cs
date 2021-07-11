using System;
					
public class Program
{
	public static void Main()
	{
		MyTestClass testClass = new MyTestClass();
		testClass.Method1();
		
		MyTestClass2 testClass2 = new MyTestClass2();
		testClass2.Method1();
		testClass2.Method2();
	}
}

public sealed class MyTestClass
{
	public void Method1(){
		Console.WriteLine("hey");
	}
}

public partial class MyTestClass2 
{
	public void Method1(){
		Console.WriteLine("partial class 1");
	}
}

public partial class MyTestClass2
{
	public void Method2(){
		Console.WriteLine("partial class 2");
	}
}
