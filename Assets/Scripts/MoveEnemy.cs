using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    [SerializeField] float m_speed = 4.0f;
    private Rigidbody2D m_body2d;
    public bool  _isMoving = true;
    private WolfAnimations _animations;
    private bool m_FacingRight = true; 
    private float _inputX;
    private Transform Player;
       void Start()
    {
        m_body2d = GetComponent<Rigidbody2D>(); 
        _animations = GetComponent<WolfAnimations>();
        Player = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move(m_speed);
   
    }
     void Move(float m_speed)
    {   
       
        _animations.IsMoving=true;  
         if (Player.transform.position.x < transform.position.x ){
            m_body2d.velocity = new Vector2(-m_speed, m_body2d.velocity.y);
            
            if(!m_FacingRight){
                transform.Rotate(0f, 180f, 0f);
                m_FacingRight = !m_FacingRight;
            }
        }
        else{
            m_body2d.velocity = new Vector2(m_speed, m_body2d.velocity.y);
            if(m_FacingRight){
                transform.Rotate(0f, 180f, 0f);
                m_FacingRight = !m_FacingRight;
            }
            
        }
        
    }
    private void Flip()
	{
		transform.Rotate(0f, 180f, 0f);
	}
}
