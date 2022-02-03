using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWolfAttack : MonoBehaviour
{
    private WolfAnimations _animations;
    private PlayerController _playerController;
    private float _damage = 50f;
    public float AttackRange = 0.5f;
    public bool Attack = false;
    public Transform AttackPoint;
    public LayerMask PlayerMask;
    // Start is called before the first frame update
    void Start()
    {
        _animations = GetComponent<WolfAnimations>();
        _playerController =  GameObject.Find("Player").GetComponent<PlayerController>();
    }

       void AttackPlayer(){
        
        Attack=true;
        Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(AttackPoint.position,AttackRange,PlayerMask);
        foreach(Collider2D Player in hitPlayer){
            
            if(Player!=null){
            Debug.Log("Wolf hit Player");
            Player.gameObject.GetComponent<PlayerController>().TakePlayerDamage(_damage);
            _animations.isAttack();
            }
        } 
       
       
    }
    private void OnDrawGizmosSelected() {
        if(AttackPoint == null){
            return;
        }
        Gizmos.DrawWireSphere(AttackPoint.position,AttackRange);
    }
     IEnumerator ReloadAttack(){
        yield return new WaitForSeconds(0.7f);
        Attack = false;
    }
    private void OnCollisionEnter2D(Collision2D other) {
        AttackPlayer();
        StartCoroutine(ReloadAttack());
    }
}
