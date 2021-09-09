using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Car
	{
		public Car() { }
		//1
		private int myCarCostVar;
		public int MyCarCost
		{
			get { return myCarCostVar; }
			set { myCarCostVar = value; }
		}
		//2
		private int myEngineVar;
		public int MyEngineCost
		{
			get { return myEngineVar; }
			set { myEngineVar = value; }
		}
		//3
		private int myNoSeatsVar;
		public int MyCarSeat
		{
			get { return myNoSeatsVar; }
			set { myNoSeatsVar = value; }
		}
		//4
		private int myMaintenanceVar;
		public int MyCarMaintenance
		{
			get { return myMaintenanceVar; }
			set { myMaintenanceVar = value; }
		}
		//5
		private int myInsuranceVar;
		public int MyCarInsurance
		{
			get { return myInsuranceVar; }
			set { myInsuranceVar = value; }
		}
		//6
		private int myModelNoVar;
		public int MyCarModelNo
		{
			get { return myModelNoVar; }
			set { myModelNoVar = value; }
		}
		//7
		private int myRegNoVar;
		public int MyCarRegNo
		{
			get { return myRegNoVar; }
			set { myRegNoVar = value; }
		}
		//8
		private int myRepairVar;
		public int MyCarRepair
		{
			get { return myRepairVar; }
			set { myRepairVar = value; }
		}
		//9
		private int myTyreCostVar;
		public int MyCarTyreCost
		{
			get { return myTyreCostVar; }
			set { myTyreCostVar = value; }
		}
		//10
		private string myNameVar;
		public string MyCarName
		{
			get { return myNameVar; }
			set { myNameVar = value; }
		}

		public static void Main(string[] args)
		{
			Car myObj = new Car();
			myObj.MyCarCost = 100;
			Console.WriteLine(myObj.MyCarCost);
		}
	}


}
