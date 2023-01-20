using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Variables;


// Scriptable object so we can get the refs for the variables
namespace GameTool
{
    [CreateAssetMenu( fileName = "Tool Container", menuName = "ScriptableObjects/ToolSO", order = 0 )]
    public class ToolContainer : ScriptableObject
    {
        public FloatWrapper forwardThrust;
        public FloatWrapper rotationThrust;
        public IntWrapper startHealth;
        public FloatWrapper laserSpeed;
        public FloatWrapper gunDelay;
        public Vec2Wrapper spawnTime;
        public Vec2IntWrapper spawnAmount;
        public Vec2Wrapper asteroidForce;
        public Vec2Wrapper asteroidSize;
        public Vec2Wrapper asteroidTorque;
    }
}