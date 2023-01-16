using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

// Makes an inspector editor for the Tool Container

[CustomEditor(typeof(ToolContainer))]
public class ToolEditor : Editor
{
    [SerializeField] private VisualTreeAsset uXML;

    public override VisualElement CreateInspectorGUI()
    {
        var root = new VisualElement();
        var tree = uXML.Instantiate();
        
        root.Add(tree);
        
        // Default inspector

        var foldout = new Foldout() { viewDataKey = "ToolContainerFullInspectorFoldout", text = "Full Inspector" };
        InspectorElement.FillDefaultInspector(foldout, serializedObject, this);
        root.Add(foldout);

        return root;
    }

}
