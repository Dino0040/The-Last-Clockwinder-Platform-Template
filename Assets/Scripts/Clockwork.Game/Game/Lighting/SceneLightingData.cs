using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Lighting
{
	[Serializable]
	public class SceneLightingData
	{
		[Serializable]
		public class RendererData
		{
			public Vector4 LightmapScaleOffset;

			public int LightmapIndex;
		}

		[Serializable]
		public class Lightmap
		{
			public Texture2D Color;

			public Texture2D Direction;

			public Texture2D ShadowMask;
		}

		[Serializable]
		public struct RendererEntry
		{
			public string EditTimeId;

			public string UnpackedId;

			public RendererData Data;
		}

		[Serializable]
		public struct ReflectionProbeEntry
		{
			public string EditTimeId;

			public string UnpackedId;

			public Texture Data;
		}

		public List<RendererEntry> Renderers = new List<RendererEntry>();

		public List<ReflectionProbeEntry> ReflectionProbes = new List<ReflectionProbeEntry>();

		public List<Lightmap> Lightmaps = new List<Lightmap>();

		public LightProbes probes;
	}
}
