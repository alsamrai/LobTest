using System;

namespace Lob5
{
	/*
	 * this is a commet to add new commit on git 
	 */
	public class Battery
	{
		private String model;
		private float idle;
		private float hoursTalk;

		//enum battries {model, idle, hoursTalk};
		public Battery ()
		{
			model = "abc";
			idle = 5;
			hoursTalk = 0;
		}

		public Battery (String m, float idl, float hour)
		{
			model = m;
			idle = idl;
			hoursTalk = hour;
		}

		/*public String BatModel
		{
			get{ return model;}
			set{ model = value;}
		}
		public float IdleTime
		{
			get{ return idle;}
			set{ idle = value;}
		}
		public float HoursTalk
		{
			get{ return hoursTalk;}
			set{ hoursTalk = value;}
		}*/
		public override string ToString ()
		{
			return "Model: " + model + ", " + "idle time: " + idle + ", " + "hours Of Talk: " + hoursTalk;
		}
	}
}

