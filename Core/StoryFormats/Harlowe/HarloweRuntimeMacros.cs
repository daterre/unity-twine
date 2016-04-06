﻿using UnityEngine;
using System.Collections;
using System;

namespace UnityTwine.StoryFormats.Harlowe
{
	public class HarloweRuntimeMacros: TwineRuntimeMacros
	{
		// ------------------------------------

		public void click(string text)
		{
			throw new System.NotImplementedException();
		}

		public void click(TwineNamedFragment namedFragment)
		{
			throw new System.NotImplementedException();
		}
		
		// ------------------------------------

		public TwineVar a(params TwineVar[] vals)
		{
			return new HarloweArray(vals);
		}

		public TwineVar dataset(params TwineVar[] vals)
		{
			return new HarloweDataset(vals);
		}

		public TwineVar datamap(params TwineVar[] vals)
		{
			return new HarloweDatamap(vals);
		}

		// ------------------------------------

		public TwineVar ceil(double num)
		{
			return Mathf.CeilToInt((float)num);
		}

		public TwineVar round(double num)
		{
			return Mathf.RoundToInt((float)num);
		}

		public TwineVar round(double num, int precision)
		{
			return Math.Round(num, precision);
		}

		public TwineVar either(params TwineVar[] vars)
		{
			return vars[UnityEngine.Random.Range(0, vars.Length)];
		}
	}
}
