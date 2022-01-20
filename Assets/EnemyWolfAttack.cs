using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWolfAttack : MonoBehaviour
{
    private WolfAnimations _animations;
    private PlayerController _playerController;
    private float _damage = 50f;
    public float _attackRange = 0.5f;
    public bool _attack = false;
    public Transform attackPoint;
    public LayerMask PlayerMask;
    // Start is called before the first frame update
    void Start()
    {
        _animations = GetComponent<WolfAnimations>();
        _playerController =  GameObject.Find("Player").GetComponent<PlayerController>();
    }

       void AttackPlayer(){
        
        _attack=true;
        Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(attackPoint.position,_attackRange,PlayerMask);
        foreach(Collider2D Player in hitPlayer){
            
            if(Player!=null){
            Debug.Log("Wolf hit Player");
            Player.gameObject.GetComponent<PlayerController>().TakePlayerDamage(_damage);
            _animations.isAttack();
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
    private void OnCollisionEnter2D(Collision2D other) {
        AttackPlayer();
        StartCoroutine(ReloadAttack());
    }
}
