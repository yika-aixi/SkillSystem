using System;
using UnityEngine;
using CabinIcarus.IcSkillSystem.SkillSystem.Runtime.Utils;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/UnityEngine/PhysicsModule/RaycastHit Value")]
    public partial class RaycastHitValueNode:ValueNode<ValueInfo<UnityEngine.RaycastHit>>
    {
        [SerializeField]
        private UnityEngine.RaycastHit _value;
   
        private ValueInfo<UnityEngine.RaycastHit> _variableValue = new ValueInfo<UnityEngine.RaycastHit>();
   
        protected override ValueInfo<UnityEngine.RaycastHit> GetTValue()
        {
            _variableValue.Value = _value;
            return _variableValue;
        }
    }
}