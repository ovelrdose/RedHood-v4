using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWolfStateManager : MonoBehaviour
{
    EnemyWolfBaseState _currentState;
    public EnemyWolfIdleState wolfIdleState = new EnemyWolfIdleState();
    public EnemyWolfMoveState wolfMoveState = new EnemyWolfMoveState();
    public EnemyWolfAwayState wolfAwayState = new EnemyWolfAwayState();
    public EnemyWolfDie wolfDieState = new EnemyWolfDie();
    void Start()
    {
        _currentState = wolfIdleState;
        _currentState.EnterState(this);
    }

    
    void Update()
    {
        _currentState.UpdateState(this);
    }
    public void SwitchState(EnemyWolfBaseState state){
        _currentState = state;
        state.EnterState(this);
    }
}

