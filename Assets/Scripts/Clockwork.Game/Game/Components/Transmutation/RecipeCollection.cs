using UnityEngine;

namespace Game.Components.Transmutation
{
	[CreateAssetMenu(fileName = "Recipes", menuName = "ASG/Recipe Collection", order = 0)]
	public class RecipeCollection : ScriptableObject
	{
		public TransmutationRecipe[] Recipes;
	}
}
