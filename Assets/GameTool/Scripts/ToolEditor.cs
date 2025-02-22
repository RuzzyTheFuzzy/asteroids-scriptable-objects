using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Timeline;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

// Makes an inspector editor for the Tool Container
namespace GameTool
{
    [CustomEditor( typeof( ToolContainer ) )]
    public class ToolEditor : Editor
    {
        private string uXMLPath = "Assets/GameTool/ToolVisual.uxml";
        private VisualTreeAsset uXML;

        public override VisualElement CreateInspectorGUI( )
        {
            // Load via path as scripts dont keep refs on runtime
            if ( uXML == null )
                uXML = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>( uXMLPath );

            if ( uXML == null )
            {
                Debug.LogError( "UXML Path is invalid!" );
                return null;
            }

            var root = new VisualElement();
            var tree = uXML.Instantiate();

            // Add UXML
            root.Add( tree );
            
            // Default inspector in foldout for adding SO references

            var foldout = new Foldout() { viewDataKey = "ToolContainerFullInspectorFoldout", text = "Scriptable Object References" };
            InspectorElement.FillDefaultInspector( foldout, serializedObject, this );
            root.Add( foldout );


            return root;
        }
    }
}