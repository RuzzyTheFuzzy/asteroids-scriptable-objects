using System;
using Unity.Properties;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UIElements;

namespace Variables
{
    [CreateAssetMenu(fileName = "new FloatVariable", menuName = "ScriptableObjects/Variables/FloatVariable")]
    public class FloatVariable : ScriptableObject
    {
        [Range(0f, 10f)] public float Value;
        public float test = 2;
    }

    // Scriptable Obj can't have a custom drawer, so a wrapper is needed
    [Serializable]
    public class FloatWrapper
    {
        public FloatVariable floatVariable;
    }

    [CustomPropertyDrawer( typeof( FloatWrapper ) )]
    public class FloatVariableEditor : PropertyDrawer
    {
        public override VisualElement CreatePropertyGUI( SerializedProperty property )
        {
            var container = new VisualElement();

            var original = new PropertyField( property.FindPropertyRelative( "floatVariable" ) );
            var value = new PropertyField( property.FindPropertyRelative( "floatVariable.test" ) );
            
            container.Add(original);
            container.Add(value);

            return container;
        }
    }
}
