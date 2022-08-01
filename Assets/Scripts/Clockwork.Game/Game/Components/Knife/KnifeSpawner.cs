using Core.Audio;
using NewtonVR;
using UnityEngine;

namespace Game.Components.Knife
{
	public class KnifeSpawner : MonoBehaviour
	{
		public UnityGuid RespawnSound;

		public GameObject Knife;

		public Transform Loc_SpawnLocation;

		public NVRLever Lever;
	}
}
