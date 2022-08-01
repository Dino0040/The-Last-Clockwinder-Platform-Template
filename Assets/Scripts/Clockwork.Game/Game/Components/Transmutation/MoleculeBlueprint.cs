using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Components.Rezources;

namespace Game.Components.Transmutation
{
	[Serializable]
	public class MoleculeBlueprint
	{
		[Serializable]
		public struct Node
		{
			public ResourceFlavor Flavor;
		}

		[Serializable]
		public struct Edge
		{
			public int Left;

			public int Right;
		}

		public const int MaxNodes = 8;

		public List<Node> Nodes;

		public List<Edge> Edges;
	}
}
