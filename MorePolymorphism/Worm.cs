﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	internal class Worm : Animal
	{
		public override string Name { get; protected set; }
		public override double Weight { get; protected set; }
		public override int Age { get; protected set; }
		public override int CutnessLevel { get; protected set; }
		public bool IsPoisonous { get; protected set; }

		public Worm(string name, double weight, int age, int cutenessLevel, bool isPoisonous)
		{
			Name = name;
			Weight = weight;
			Age = age;
			CutnessLevel = cutenessLevel;
			IsPoisonous = isPoisonous;
		}

		public override string DoSound()
		{
			return "exists";
		}
		public override string Stats()
		{
			return $"{base.Stats()}, IsPoisonous: {IsPoisonous}";
		}
	}
}
