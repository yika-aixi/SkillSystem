using System;
using UnityEngine;
using CabinIcarus.IcSkillSystem.SkillSystem.Runtime.Utils;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/System/Char Value")]
    public partial class CharValueNode:ValueNode<ValueInfo<System.Char>>
    {
        [SerializeField]
        private System.Char _value;
   
        private ValueInfo<System.Char> _variableValue = new ValueInfo<System.Char>();
   
        protected override ValueInfo<System.Char> GetTValue()
        {
            _variableValue.Value = _value;
            return _variableValue;
        }
    }
}