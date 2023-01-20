using UnityEngine;
using Variables;
using System;

// This is so that values in the scriptable objects can be bound
// using their binding path to the ui elements using ui builder

namespace GameTool
{
    // Make value serilazable in order to bind to UI
    [Serializable]
    public class Vec2Wrapper : ISerializationCallbackReceiver
    {
        public Vec2Variable variable;

        public Vector2 value;

        public void OnBeforeSerialize( )
        {
            if ( variable != null )
                value = variable.value;
        }

        public void OnAfterDeserialize( )
        {
            // Incase variable value is limited
            if ( variable != null )
            {
                variable.value = value;
                value = variable.value;
            }
        }
    }
    
    [Serializable]
    public class Vec2IntWrapper : ISerializationCallbackReceiver
    {
        public Vec2IntVariable variable;

        public Vector2Int value;

        public void OnBeforeSerialize( )
        {
            if ( variable != null )
                value = variable.value;
        }

        public void OnAfterDeserialize( )
        {
            if ( variable != null )
            {
                variable.value = value;
                value = variable.value;
            }
        }
    }
    
    [Serializable]
    public class FloatWrapper : ISerializationCallbackReceiver
    {
        public FloatVariable variable;

        public float value;

        public void OnBeforeSerialize( )
        {
            if ( variable != null )
                value = variable.value;
        }

        public void OnAfterDeserialize( )
        {
            if ( variable != null )
            {
                variable.value = value;
                value = variable.value;
            }
        }
    }
    
    [Serializable]
    public class IntWrapper : ISerializationCallbackReceiver
    {
        public IntVariable variable;

        public int value;

        public void OnBeforeSerialize( )
        {
            if ( variable != null )
                value = variable.value;
        }

        public void OnAfterDeserialize( )
        {
            if ( variable != null )
            {
                variable.value = value;
                value = variable.value;
            }
        }
    }
}
