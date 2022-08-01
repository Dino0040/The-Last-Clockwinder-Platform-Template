using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using Game.Lighting;
using System.Linq;

public class LightingDataMethods : MonoBehaviour
{
    [MenuItem("Mod/Populate Lighting Data")]
    static void PopulateLightingData()
    {
        Scene scene = SceneManager.GetActiveScene();
        GameObject[] rootObjects = scene.GetRootGameObjects();

        SceneLightingDataStore sceneLightingDataStore = null;
        foreach (GameObject rootObject in rootObjects)
        {
            if (sceneLightingDataStore = rootObject.GetComponent<SceneLightingDataStore>())
            {
                break;
            }
        }
        
        Undo.RecordObject(sceneLightingDataStore, "Lighting Update");
        sceneLightingDataStore.Serialized.Clear();
        if (!sceneLightingDataStore.DayLighting)
        {
            sceneLightingDataStore.DayLighting = ScriptableObject.CreateInstance<SceneLightingDataAsset>();
            AssetDatabase.CreateAsset(sceneLightingDataStore.DayLighting, $"Assets/{scene.name}_Day.asset");
        }
        sceneLightingDataStore.DayLighting.Data.Renderers.Clear();
        sceneLightingDataStore.DayLighting.Data.ReflectionProbes.Clear();
        sceneLightingDataStore.DayLighting.Data.probes = null;
        sceneLightingDataStore.DayLighting.Data.Lightmaps.Clear();

        LightmapData[] lightmapData = LightmapSettings.lightmaps;
        for (int i = 0; i < lightmapData.Length; i++)
        {
            SceneLightingData.Lightmap lightmap = new SceneLightingData.Lightmap()
            {
                Color = lightmapData[i].lightmapColor,
                Direction = lightmapData[i].lightmapDir
            };
            sceneLightingDataStore.DayLighting.Data.Lightmaps.Add(lightmap);
        }

        MeshRenderer[] meshRenderers = rootObjects
            .SelectMany(o => o.GetComponentsInChildren<MeshRenderer>())
            .Where(m => m.receiveGI == ReceiveGI.Lightmaps && m.lightmapIndex >= 0 && m.lightmapIndex < lightmapData.Length)
            .ToArray();
        GlobalObjectId[] globalRendererIds = new GlobalObjectId[meshRenderers.Length];
        GlobalObjectId.GetGlobalObjectIdsSlow(meshRenderers, globalRendererIds);

        for (int i = 0; i < meshRenderers.Length; i++)
        {
            MeshRenderer meshRenderer = meshRenderers[i];

            SceneLightingDataStore.SerializedPair serializedPair = new SceneLightingDataStore.SerializedPair
            {
                EditTimeId = globalRendererIds[i].ToString(),
                Reference = meshRenderer
            };
            sceneLightingDataStore.Serialized.Add(serializedPair);

            SceneLightingData.RendererEntry rendererEntry = new SceneLightingData.RendererEntry {
                Data = new SceneLightingData.RendererData {
                    LightmapIndex = meshRenderer.lightmapIndex,
                    LightmapScaleOffset = meshRenderer.lightmapScaleOffset
                },
                EditTimeId = globalRendererIds[i].ToString(),
                UnpackedId = globalRendererIds[i].ToString()
            };
            sceneLightingDataStore.DayLighting.Data.Renderers.Add(rendererEntry);
        }

        EditorUtility.SetDirty(sceneLightingDataStore.DayLighting);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
}
