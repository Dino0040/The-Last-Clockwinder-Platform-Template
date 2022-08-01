using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Lighting
{
	[Serializable]
	public class SceneLightingDataStore : MonoBehaviour
	{
		[Serializable]
		public struct SerializedPair
		{
			public string EditTimeId;

			public UnityEngine.Object Reference;
		}
		
		public SceneLightingDataAsset DayLighting;

		public SceneLightingDataAsset NightLighting;
		
		[SerializeField]
		private List<SerializedPair> serialized = new List<SerializedPair>();

		public List<SerializedPair> Serialized
        {
            get
            {
				return serialized;
            }
            set
            {
				serialized = value;
            }
        }
	}
}
