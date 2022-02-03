using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    [SerializeField] float m_speed = 4.0f;
    private Rigidbody2D _body2d;
    //public bool  isMoving = true;
    private WolfAnimations _animations;
    private bool _facingRight = true; 
    private float _inputX;
    private Transform _player;
       void Start()
    {
        _body2d = GetComponent<Rigidbody2D>(); 
        _animations = GetComponent<WolfAnimations>();
        _player = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move(m_speed);
   
    }
     void Move(float m_speed)
    {   
       
        _animations.IsMoving=true;  
         if (_player.transform.position.x < transform.position.x ){
            _body2d.velocity = new Vector2(-m_speed, _body2d.velocity.y);
            
            if(!_facingRight){
                transform.Rotate(0f, 180f, 0f);
                _facingRight = !_facingRight;
            }
        }
        else{
            _body2d.velocity = new Vector2(m_speed, _body2d.velocity.y);
            if(_facingRight){
                transform.Rotate(0f, 180f, 0f);
                _facingRight = !_facingRight;
            }
            
        }
        
    }
    private void Flip()
	{
		transform.Rotate(0f, 180f, 0f);
	}
}
