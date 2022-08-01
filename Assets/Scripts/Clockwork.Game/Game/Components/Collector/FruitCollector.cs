using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Core.Serialization;
using Game.Components.Metrics;
using Game.Components.Rezources;
using Game.Platforms;
using TMPro;
using UnityEngine;

namespace Game.Components.Collector
{
	public class FruitCollector : SavableBehaviour
	{
		public Collider InBucketTrigger;

		public TextMeshPro[] UICards;

		public OutputTracker Output;

		public bool UseDesignatedResourceFlavor;

		public ResourceFlavor DesignatedResourceFlavor;
		
		[HideInInspector] public ResourceCollection Resources = new ResourceCollection();

		[HideInInspector] public List<ResourceAmount> StartingResources = new List<ResourceAmount>();
	}
}
