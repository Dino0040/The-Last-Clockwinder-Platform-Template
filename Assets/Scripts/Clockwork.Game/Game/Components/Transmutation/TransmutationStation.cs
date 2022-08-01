using Core.Coroutines;
using NewtonVR;
using UnityEngine;
using Global.Utilities.Unity.Springs;

namespace Game.Components.Transmutation
{
	public class TransmutationStation : CoroutineBehaviour
	{
		public RecipeCollection RecipeCollection;

		[Header("Configuration")]
		public float CookTimeBeats = 8f;

		public float LidClosedHeight = 0.843f;

		public float LaunchVelocity = 6f;

		public float LaunchAngle = 45f;

		[Header("References")]
		public Transform Lid;

		public NVRLever Lever;

		public Animator OutputLidAnimator;

		public Collider Trigger;

		public Transform AttractionLocation;

		public Transform OutputSpawnLocation;

		public AnimationCurve AttractionForceToCenterByDistance;

		public SpringFloat TransmuteEffectSpring = new SpringFloat();

		public ParticleSystem SmokeEmitter;
	}
}
