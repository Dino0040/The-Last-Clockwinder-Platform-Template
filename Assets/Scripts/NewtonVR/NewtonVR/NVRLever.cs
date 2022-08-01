using Core.Audio;
using UnityEngine;
using UnityEngine.Events;

namespace NewtonVR
{
	public sealed class NVRLever : MonoBehaviour
	{
		public enum LeverPosition
		{
			Off = 0,
			Mid = 1,
			On = 2
		}

		public enum LeverType
		{
			Trigger = 0,
			Toggle = 1
		}

		public HingeJoint Hinge;

		//public NVRInteractableItem Handle;

		[Tooltip("Detaches the grabbing hand when the lever engages.")]
		public bool DetachOnEngage;

		[Tooltip("Locks the lever in place when it engages.")]
		public bool LockOnEngage;

		public LeverType Type;

		[Tooltip("How long the lever stays down when engaging.")]
		public float EngageWaitTime = 1f;

		[Tooltip("The point above which the lever is 'on'. [0,1]")]
		public float EngageActivationPoint = 0.75f;

		[Tooltip("The point below which the lever is 'off'. [0,1]")]
		public float DisengageActivationPoint = 0.15f;

		public float CurrentValue;

		public LeverPosition CurrentLeverPosition;

		public UnityEvent OnEngage;

		public UnityEvent OnDisengage;

		public UnityGuid LeverEngageSound;
	}
}
