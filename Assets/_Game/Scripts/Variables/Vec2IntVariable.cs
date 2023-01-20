using System;
using UnityEngine;

namespace Variables
{
    // Instead of doing a seperate SO for min and max
    [CreateAssetMenu( fileName = "new Vec2IntVariable", menuName = "ScriptableObjects/Variables/Vec2IntVariable" )]
    public class Vec2IntVariable : ScriptableObject
    {
        public Vector2Int value;
    }
}
