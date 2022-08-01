using Core.Audio;
using Game.UI.CircleLoading;
using UnityEngine;

namespace Prototype.Components
{
	public class VerticalBonderSpawner : MonoBehaviour
	{
		[Header("References")]
		public GameObject ToSpawn;

		public CircleLoading LoadingCircle;

		public Transform Loc_ToSpawn;

		[Header("Configuration")]
		public float SpawnTime;

		public float SpawnDistance = 0.25f;

		public bool SpawnKinematic;

		public UnityGuid SpawnAudio;
	}
}
