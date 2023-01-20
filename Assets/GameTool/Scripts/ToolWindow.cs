using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;
using Variables;

// Displays the inspector for the tool container in a seperate window
// Couldn't bind the values in the UI Builder otherwise
namespace GameTool
{
    public class ToolWindow : EditorWindow
    {
        private string containerPath = "Assets/GameTool/Tool Container.asset";
        private ToolContainer container;

        // Make tool accessable from window tab
        [MenuItem( "Tools/Game Tool" )]
        public static void Init( )
        {
            //Show existing window instance. If one doesn't exist, make one.
            var window = GetWindow( typeof( ToolWindow ), false, "Game Tool" );
            window.Show();
        }

        private void CreateGUI( )
        {
            // Load via path as scripts dont keep refs on runtime
            if ( container == null )
                container = AssetDatabase.LoadAssetAtPath<ToolContainer>( containerPath );

            if ( container == null )
            {
                Debug.LogError( "ToolContainer Path is invalid!" );
                return;
            }

            var root = new VisualElement();
            var inspector = new InspectorElement( container ); // Create the inspector

            root.Add( inspector );

            rootVisualElement.Add( root );
        }
    }
}