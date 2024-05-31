﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	internal class Wolf : Animal
	{
		public override string Name { get; protected set; }
		public override double Weight { get; protected set; }
		public override int Age { get; protected set; }
		public override int CutnessLevel { get; protected set; }
		public bool PackLeader { get; protected set; }

		public Wolf(string name, double weight, int age, int cutenessLevel, bool packLeader)
		{
			Name = name;
			Weight = weight;
			Age = age;
			CutnessLevel = cutenessLevel;
			PackLeader = packLeader;
		}

		public override string DoSound()
		{
			return "awoo";
		}
		public override string Stats()
		{
			return $"{base.Stats()}, PackLeader: {PackLeader}";
		}
	}
}