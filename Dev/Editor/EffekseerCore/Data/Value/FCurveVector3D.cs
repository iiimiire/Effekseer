﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Effekseer.Data.Value
{
	public class FCurveVector3D
	{
		public FCurve<float> X { get; private set; }
		public FCurve<float> Y { get; private set; }
		public FCurve<float> Z { get; private set; }

		public FCurveVector3D()
		{
			X = new FCurve<float>(0);
			Y = new FCurve<float>(0);
			Z = new FCurve<float>(0);
		}

		public byte[] GetBytes(float mul = 1.0f)
		{
			List<byte[]> data = new List<byte[]>();
			data.Add(X.GetBytes(mul));
			data.Add(Y.GetBytes(mul));
			data.Add(Z.GetBytes(mul));
			return data.SelectMany(_ => _).ToArray();
		}
	}
}
