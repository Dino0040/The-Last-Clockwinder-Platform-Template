using UnityEngine;
using UnityEngine.Events;

namespace Game.Components.Hands
{
	public class SummonTarget : MonoBehaviour
	{
		public MeshRenderer[] Renderers;

		public UnityEvent OnSummon;
	}
}
