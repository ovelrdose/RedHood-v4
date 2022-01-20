
using UnityEngine;
public abstract class EnemyWolfBaseState
{
    public abstract void EnterState(EnemyWolfStateManager enemy);
    public abstract void UpdateState(EnemyWolfStateManager enemy);
    public abstract void onCollisionEnter(EnemyWolfStateManager enemy);
    
}
