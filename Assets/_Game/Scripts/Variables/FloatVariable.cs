using System;
using Unity.Properties;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UIElements;

namespace Variables
{
    [CreateAssetMenu( fileName = "new FloatVariable", menuName = "ScriptableObjects/Variables/FloatVariable" )]
    public class FloatVariable : ScriptableObject
    {
        public float value;
    }

    // Make SO float variable bindable (Cause scriptable objects values arent?!?)
    // Hours wasted: 14
    [Serializable]
    public class FloatWrapper : ISerializationCallbackReceiver
    {
        public FloatVariable variable;

        public float value;

        public void OnBeforeSerialize( )
        {
            if ( variable != null )
                value = variable.value;
        }

        public void OnAfterDeserialize( )
        {
            // Incase variable value is limited
            if ( variable != null )
            {
                variable.value = value;
                value = variable.value;
            }
        }
    }
}