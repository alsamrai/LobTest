using System;

namespace Lob5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Phone ph = new Phone ();
			Console.WriteLine (ph);
			Console.WriteLine ();

			Phone ph1 = new Phone ("Samsung", 540, "Unknown", 5.6, "Black");
			Console.WriteLine (ph1);
			Console.WriteLine ();

			ph.PhoneModel = "HTC";
			ph.PhoneOwner = "ABC";
			ph.PhonePrice = 250;
			ph.PhoneScreanSize = 3.7;
			ph.PhoneScreenColor = "Blue";
			Console.WriteLine (ph);
		}
	}
}
