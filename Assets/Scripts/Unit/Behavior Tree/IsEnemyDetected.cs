using UnityEngine;
using static Node_script;

/// <summary>
/// See if an enemy is in the area of the unit
/// </summary>

public class IsEnemyDetected : Node
{
    UnitCombat _unit;
    UnitBT _unitBT;

    public IsEnemyDetected(GameObject unit)
    {
        _unit = unit.GetComponent<UnitCombat>();
        _unitBT = unit.GetComponent<UnitBT>();
    }

    public override NodeState Evaluate()
    {
        bool enemyAround = _unit.IsEnemyInMyArea();
        if (enemyAround || _unit.lastPosition != Vector3.zero )
        {
            if(enemyAround)
            {
                _unitBT.SwitchState(AIState.Attacking);
            }
            else
            {
                _unitBT.SwitchState(AIState.Seaching);
            }

            return NodeState.SUCCESS;
        }
        _unit.canAttack = false;
        return NodeState.FAILURE;
    }
}
