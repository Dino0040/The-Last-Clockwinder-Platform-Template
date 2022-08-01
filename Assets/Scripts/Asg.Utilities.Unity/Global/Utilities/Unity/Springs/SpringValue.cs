using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Global.Utilities.Unity.Springs
{
	[Serializable]
	public abstract class SpringValue<T> where T : struct
	{
		public T TargetValue;

		public T CurrentValue;

		public T CurrentVelocity;

		public float SpringConstantK;
		
		public float SpringConstantDamping;
	}
}
