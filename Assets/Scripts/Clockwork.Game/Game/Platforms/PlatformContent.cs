using Game.Timeline;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Serialization;

namespace Game.Platforms
{
	public class PlatformContent : MonoBehaviour
	{
		public enum TransitionDirection
		{
			In = 0,
			Out = 1
		}

		public Rigidbody JointsRigidbody;

		public Transform MovingTransform;

		[FormerlySerializedAs("PuzzleHolderDirector")]
		public FixedUpdatePlayableDirector PlatformHolderDirector;

		public PlayableAsset PlatformTransitionOut;

		public PlayableAsset PlatformTransitionIn;
	}
}
