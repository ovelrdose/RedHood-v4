using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerCombat : MonoBehaviour
{
    private PlayerAnimations _animations;
    private PlayerController _playerController;
    private float _damage = 50f;
    public float _attackRange = 0.5f;
    public bool _attack = false;
    public Transform attackPoint;
    public LayerMask EnemyMask;
    



    
    void Start()
    {
        _animations = GetComponent<PlayerAnimations>();
        _playerController =  GetComponent<PlayerController>();
        
    }

    void Update()
    {
         if(Input.GetMouseButtonDown(1)&& _attack == false &&_playerController._isGrounded == true){
            AttackEnemy();
            StartCoroutine(ReloadAttack());
        }
    }

    void AttackEnemy(){
        _attack=true;
        _animations.Combo();
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position,_attackRange,EnemyMask);
        foreach(Collider2D enemy in hitEnemies){
            
            if(enemy!=null){
            Debug.Log("We hit");
            enemy.gameObject.GetComponent<Enemy>().TakeEnemyDamage(_damage);
            }
        } 
       
       
    }
    private void OnDrawGizmosSelected() {
        if(attackPoint == null){
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position,_attackRange);
    }
     IEnumerator ReloadAttack(){
        yield return new WaitForSeconds(0.7f);
        _attack = false;
    }
}
