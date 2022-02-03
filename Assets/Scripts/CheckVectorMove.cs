using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckVectorMove : MonoBehaviour
{
   public Transform CurrentPosition;
    private Rigidbody2D _wolfRB; 
    private WolfAnimations _animations;
    private GameObject _player;
    public Vector3 _startEnemyPos;
    public bool _facingRight = true;
    public bool IsLeft;
    // Start is called before the first frame update
    void Start()
    {
        _wolfRB = GetComponent<Rigidbody2D>();
        _animations = GetComponent<WolfAnimations>();
        _player = GameObject.Find("Player");
        _startEnemyPos = transform.position;
    }

    public void CheckVector(){
         if (_player.transform.position.x < _wolfRB.transform.position.x ){
                IsLeft=true;
            }
         if (_player.transform.position.x > _wolfRB.transform.position.x ){
                IsLeft=false;
            }
        
    }
}
