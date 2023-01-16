using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Variables;

// Scriptable object so we can bind values with the ui builder

[CreateAssetMenu(fileName = "Tool Container", menuName = "ScriptableObjects/ToolSO", order = 0)]
public class ToolContainer : ScriptableObject
{
    [SerializeField] public FloatWrapper thrust;
    
}
