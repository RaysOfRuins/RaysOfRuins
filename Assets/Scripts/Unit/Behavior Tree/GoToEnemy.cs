using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.AI;
using static Node_script;

public class GoToEnemy : Node
{
    UnitCombat _unit;
    UnitMovement _unitMovement;
    NavMeshAgent _agent;
    Transform _transform;

    public GoToEnemy(GameObject unit, NavMeshAgent agent)
    {
        _unit = unit.GetComponent<UnitCombat>();
        _unitMovement = unit.GetComponent<UnitMovement>();
        _agent = agent;
        _transform = _unit.transform;
    }

    public override NodeState Evaluate()
    {
        if (_unit.nearestEnemy != null)
        {
                 _unitMovement.ChangeTarget(_unit.nearestEnemy.transform.position);
            return NodeState.SUCCESS;
        }

        else if(_unit.nearestEnemy == null && _unit.lastPosition != Vector3.zero && _unit.lastEnemy != null && (_agent.velocity.magnitude > 0.01f)) 
        {
            _unitMovement.ChangeTarget(_unit.lastPosition);
            return NodeState.SUCCESS;
        }
        else 
        {
            _unit.lastPosition = Vector3.zero;
        }

            return NodeState.FAILURE;
    }
}
