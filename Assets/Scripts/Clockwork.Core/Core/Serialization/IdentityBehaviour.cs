using UnityEditor;
using UnityEngine;

namespace Core.Serialization
{
	[ExecuteAlways]
	public class IdentityBehaviour : MonoBehaviour
	{
		public string Identity;

#if UNITY_EDITOR
        private void Awake()
        {
            Undo.RecordObject(this, "Identity");
            Identity = GlobalObjectId.GetGlobalObjectIdSlow(this).ToString();
        }
#endif
    }
}
