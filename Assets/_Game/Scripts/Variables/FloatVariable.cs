using System;
using UnityEngine;

namespace Variables
{
    [CreateAssetMenu( fileName = "new FloatVariable", menuName = "ScriptableObjects/Variables/FloatVariable" )]
    public class FloatVariable : ScriptableObject
    {
        public float value;
    }
}