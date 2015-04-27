// Copyright (c) 2011 Anders Gustafsson, Cureos AB.
// All rights reserved. This software and the accompanying materials
// are made available under the terms of the Eclipse Public License v1.0
// which accompanies this distribution, and is available at
// http://www.eclipse.org/legal/epl-v10.html

using System;
using Cureos.Measures.Quantities;
using NUnit.Framework;

namespace Cureos.Measures
{
	[TestFixture]
	public class ExampleTests
	{
		[Test]
		public void Example1()
		{
			Measure<Mass> initialWgt = new Measure<Mass>(75.0);
			Measure<Mass> gainedWgt = new Measure<Mass>(2.5, Mass.HectoGram);
			Measure<Mass> newWgt = initialWgt + gainedWgt;

			UnitPreservingMeasure<Mass> newWgtInGram = newWgt[Mass.Gram];
			UnitPreservingMeasure<Mass> initialWgtInGram = newWgtInGram - gainedWgt;

			Console.WriteLine("Initial weight: {0}", initialWgtInGram);

			UnitPreservingMeasure<Length> height = new UnitPreservingMeasure<Length>(30.0, Length.CentiMeter);
			Measure<Area> area = (Measure<Area>)0.02;

		    Measure<Volume> vol; ArithmeticOperations.Times(height, area, out vol);
			var maxVol = new Measure<Volume>(10.0, Volume.Liter);

			if (vol < maxVol)
			{
				Console.WriteLine("Calculated volume is within limits, actual volume: {0}", vol[Volume.Liter]);
			}

#if NUNIT24
			Assert.Ignore();
#else
			Assert.Pass();
#endif
		}
	}
}