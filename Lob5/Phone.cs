using System;

namespace Lob5
{
	public class Phone
	{
		private String model;
		private float price;
		private String owner;
		private Double screenSize;
		private String screenColor;
		private Battery batteries;
		//enum  Batteries { Lithium , Nickel };

		public Phone ()
		{
			model = "Iphone";
			price = 700;
			owner = null;
			screenSize = 16.7f;
			screenColor = " White";
			batteries = new Battery ();
		}

		public Phone(String mod, float pri, String own, Double screenSi, String screenCo)
		{
			model = mod;
			price = pri;
			owner = own;
			screenSize = screenSi;
			screenColor = screenCo;
			batteries = new Battery ();
		}

		public String PhoneModel
		{
			get{ return model;}
			set{ model = value;}
		}
		public float PhonePrice
		{
			get{ return price;}
			set{ price = value;}
		}
		public String PhoneOwner
		{
			get{ return owner;}
			set{ owner = value;}
		}
		public Double PhoneScreanSize
		{
			get{return screenSize;}
			set{ screenSize = value;}
		}
		public String PhoneScreenColor
		{
			get{ return screenColor;}
			set{ screenColor = value;}
		}

		public override string ToString ()
		{
			return "Model: " + model + ", " + "Price: " + price + ", " + "Owner: " + owner + ", " 
				+ "Screen Size: " + screenSize + ", " + "Screen Color: " + screenColor + ", " 
				+ "Battery " + batteries;
		}
	}
}

