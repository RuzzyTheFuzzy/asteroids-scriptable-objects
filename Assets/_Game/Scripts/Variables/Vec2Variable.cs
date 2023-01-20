using System;
using UnityEngine;

namespace Variables
{
    [CreateAssetMenu( fileName = "new Vec2Variable", menuName = "ScriptableObjects/Variables/Vec2Variable" )]
    public class Vec2Variable : ScriptableObject
    {
        public Vector2 value;
    }
}