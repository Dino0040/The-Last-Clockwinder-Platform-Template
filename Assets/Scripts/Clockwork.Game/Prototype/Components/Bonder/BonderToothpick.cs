using UnityEngine;

namespace Prototype.Components.Bonder
{
	public class BonderToothpick : MonoBehaviour
	{
		private enum End
		{
			Left = 0,
			Right = 1
		}

		[Header("References")]
		public Collider EndColliderLeft;

		public Collider EndColliderRight;

		public Transform FruitPositionLeft;

		public Transform FruitPositionRight;

		public Material UngrabbableMaterial;
		
		[Header("Configuration")]
		public bool FullBondCanBeGrabbed = true;
	}
}
