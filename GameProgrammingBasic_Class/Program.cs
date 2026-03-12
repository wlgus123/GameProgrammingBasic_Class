using System;

// enum
enum E_Type
{
	A = 2,
	B,      // == 3
	C = -1,
	D,      // == -1
}

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

		int? nInt = null;       // nullable 형식 (null 들어가는 변수)
		int resultVal = 0;
		resultVal = (nInt != null) ? nInt.Value : 0;    // 줄여
		resultVal = nInt ?? 0;                          // 더 줄여

		var v = 10;             // == auto

		// 출력 (줄바꿈)
		System.Console.Write("라인1");
		Console.WriteLine("라인2");       // \n
		Console.WriteLine("라인3");
	}
}
