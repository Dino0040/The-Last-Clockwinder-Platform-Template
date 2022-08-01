using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game.Components.Rezources
{
	[Serializable]
	public struct ResourceAmount
	{
		public const int EffectivelyInfinity = 1000000;

		public const int DisplayAsInfinity = 100000;

		[FormerlySerializedAs("Cost")]
		public float Number;

		[FormerlySerializedAs("Type")]
		public ResourceFlavor Flavor;
	}
}
