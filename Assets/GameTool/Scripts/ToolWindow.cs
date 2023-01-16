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
public class ToolWindow : EditorWindow
{

    [SerializeField] private ToolContainer container;
    
    // Make tool accessable from window tab
    [MenuItem("Window/Tool Window")]
    public static void Init()
    {
        //Show existing window instance. If one doesn't exist, make one.
        var window = GetWindow(typeof(ToolWindow));
        window.Show();
    }

    private void CreateGUI( )
    {
        var root = new VisualElement();
        var inspector = new InspectorElement( container ); // Create the inspector
        
        root.Add(inspector);
        
        rootVisualElement.Add(root);
    }

}
