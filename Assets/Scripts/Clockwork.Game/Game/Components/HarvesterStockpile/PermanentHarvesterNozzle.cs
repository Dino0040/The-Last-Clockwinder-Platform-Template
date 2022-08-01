using System;
using Game.Components.Collector;
using Game.Components.Metrics;
using Game.Components.Rezources;
using UnityEngine;

namespace Game.Components.HarvesterStockpile
{
	public class PermanentHarvesterNozzle : MonoBehaviour
	{
		public Rigidbody HandlePhysics;

		public float DegreesPerResourcePumped = 12f;

		public OutputTracker Output;
	}
}
