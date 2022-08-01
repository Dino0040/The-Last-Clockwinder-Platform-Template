using System;
using Game.Components.Rezources;
using UnityEngine.Serialization;

namespace Game.Components.Transmutation
{
	[Serializable]
	public class TransmutationRecipe
	{
		public MoleculeBlueprint Input;

		public ResourceFlavor[] Outputs;
	}
}
