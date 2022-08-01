using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Game.Components.Rezources;
using Game.Components.Transmutation;
using UnityEngine;

namespace Game.Components.Bonder
{
	[Serializable]
	public class BondedObjectGraph
	{
		[Serializable]
		public class Edge
		{
			public GameObject LeftObject;

			public GameObject RightObject;
		}
		
		public List<GameObject> Nodes = new List<GameObject>();

		public List<Edge> Edges = new List<Edge>();
	}
}
