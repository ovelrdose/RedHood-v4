using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireArrow : MonoBehaviour
{
    [SerializeField]private float _shootSpeed = 20f;
    public Rigidbody2D _rigidbody_2d;
    private float _damage =20f;
    

    

    void Start()
    {
        _rigidbody_2d.velocity = transform.right * _shootSpeed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo) {
        
        Enemy _enemy = hitInfo.GetComponent<Enemy>();
        if(_enemy!=null){
            Debug.Log("We hit");
            _enemy.TakeEnemyDamage(_damage);
        }
        Destroy(gameObject);
   }

}
