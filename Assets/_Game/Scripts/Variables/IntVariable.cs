using System;
using UnityEngine;

namespace Variables
{
    // TODO Can we use generics to avoid duplication?
    [CreateAssetMenu(fileName = "new FloatVariable", menuName = "ScriptableObjects/Variables/IntVariable")]
    public class IntVariable : ScriptableObject
    {
        public int value;

        private int _currentValue;

        public int Value => _currentValue;

        public virtual void ApplyChange(int change)
        {
            _currentValue += change;
        }

        public virtual void SetValue(int newValue)
        {
            _currentValue = newValue;
        }

        private void OnEnable()
        {
            _currentValue = value;
        }
    }

    public class VariableBase<T> : ScriptableObject
    {
        
    }

    public class MyIntThingie : VariableBase<int>
    {
        
    }
    
    
    // Wrapper to properly serialise IntVariable
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
            // Incase variable value is limited
            if ( variable != null )
            {
                variable.value = value;
                value = variable.value;
            }
        }
    }
}
