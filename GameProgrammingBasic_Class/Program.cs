using System;

class Program
{
	static void Main(string[] args)
	{
		byte b;     // 기본값: unsigned
		sbyte sb;   // signed를 명시
		int i;
		uint ui;
		object obj; // 모든 자료형 가져올 수 있음 (== void*) <- 근데 느림(많이 사용은 X)

		string tempStr = "123";
		int tempInt = Convert.ToInt32(tempStr);
		float tempFloat = Convert.ToSingle(tempStr);    // float == single
		string tempStr2 = "1ab23";
		int tempInt2 = int.Parse(tempStr2);     // error

		// 출력 (줄바꿈)
		System.Console.Write("라인1");
		Console.WriteLine("라인2");       // \n
		Console.WriteLine("라인3");
	}
}
