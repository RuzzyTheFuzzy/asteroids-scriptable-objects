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
    
}
