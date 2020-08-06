using System;
using UnityEngine;
using CabinIcarus.IcSkillSystem.SkillSystem.Runtime.Utils;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/UnityEngine/Physics2DModule/SimulationMode2D Value")]
    public partial class SimulationMode2DValueNode:ValueNode<ValueInfo<UnityEngine.SimulationMode2D>>
    {
        [SerializeField]
        private UnityEngine.SimulationMode2D _value;
   
        private ValueInfo<UnityEngine.SimulationMode2D> _variableValue = new ValueInfo<UnityEngine.SimulationMode2D>();
   
        protected override ValueInfo<UnityEngine.SimulationMode2D> GetTValue()
        {
            _variableValue.Value = _value;
            return _variableValue;
        }
    }
}