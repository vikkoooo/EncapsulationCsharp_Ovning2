using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class Person
	{
		// Fields
		private int age;
		private string fName = String.Empty; // Constructor unhappy otherwise
		private string lName = String.Empty; // Constructor unhappy otherwise
		private double height;
		private double weight;

		// Constructors
		public Person(string fName, string lName)
		{
			FName = fName ?? throw new ArgumentNullException(nameof(fName)); // Supress warning safe way (but constructor still unhappy)
			LName = lName!; // Supress warning unsafe way (but constructor still unhappy)
		}

		// Call constructor above, note ": this" instead of ": base"
		public Person(int age, string fName, string lName, double height, double weight)
			: this(fName, lName)
		{
			Age = age;
			Height = height;
			Weight = weight;
		}

		// Getters & setters
		public int Age
		{
			get { return age; }
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Age can not be less than or equal to zero");
				}
				else
				{
					age = value;
				}
			}
		}

		public string FName
		{
			get { return fName; }
			set
			{
				if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 10)
				{
					throw new ArgumentException("First name can not be less than two characters long or more than ten characters long");
				}
				else
				{
					fName = value;
				}
			}
		}

		public string LName
		{
			get { return lName; }
			set
			{
				if (string.IsNullOrWhiteSpace(value) || value.Length < 3 || value.Length > 15)
				{
					throw new ArgumentException("Last name can not be less than three characters long or more than fifteen characters long");
				}
				else
				{
					lName = value;
				}
			}
		}

		public double Height
		{
			get { return height; }
			set { height = value; }
		}

		public double Weight
		{
			get { return weight; }
			set { weight = value; }
		}

		// Util
		public override string ToString()
		{
			return $"Firstname: {FName}, Lastname: {LName}, Age: {Age}, Height: {height} cm, Weight: {weight} kg";
		}
	}
}

