using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    
    [SerializeField] float m_speed = 4.0f;
    float afterHitSpeed =2f;
    [SerializeField] float _jumpForce = 40f;
    private float _healthPlayer = 150;

    public bool _isGrounded = false;
    private Rigidbody2D m_body2d;
    public bool  _isMoving;
    private PlayerAnimations _animations;
    private bool m_FacingRight = true; 
    public Transform GroundCheck;

    public float groundRadius = 0.2f;
    public LayerMask groundMask;
    public HealthBar _healtBar;
    private float _inputX;
    private SpawnArrow _spawnArrow;
    private PlayerCombat _playerCombat;
    private float _currentHealth;
    public bool IsFly;
  
    
 
    void Start()
    {
        m_body2d = GetComponent<Rigidbody2D>(); 
        _animations = GetComponent<PlayerAnimations>();
        _spawnArrow = GetComponent<SpawnArrow>();
        _playerCombat = GetComponent<PlayerCombat>();
        _currentHealth = _healthPlayer;
        _healtBar.SetMaxHealth(_healthPlayer);
       
        
    }
    
   

    private bool IsFlying(){
        
        if(m_body2d.velocity.y<0 && _isGrounded==false){
            IsFly = true;
            return true;
        }
        else{
            IsFly = false;
            return false;
        }
    }
     private void FixedUpdate() {
        _isGrounded = Physics2D.OverlapCircle(GroundCheck.position,groundRadius,groundMask);
        
       _inputX = Input.GetAxis("Horizontal");
       _isMoving = _inputX!=0?true:false;

       if(_isMoving && (_spawnArrow.goArrow==false&&_playerCombat._attack==false)){
           Move(_inputX,m_speed); 
       }
       else if(_isMoving && (_spawnArrow.goArrow==true)){
           Move(_inputX,0f);     
       }
       else if (_isMoving &&(_playerCombat._attack==true)){
            Move(_inputX,afterHitSpeed); 
       }
        _animations.IsMoving =_isMoving;  
        _animations.IsFlying = IsFlying();
    }
    void Update()
    {
        if(Input.GetButtonDown("Jump") &&_isGrounded){
            
            Jump();
            _animations.Jump();
            
        }
        
        
        
        
    }
    
   
    void Move(float inputX,float m_speed)
    {

        m_body2d.velocity = new Vector2(inputX * m_speed, m_body2d.velocity.y);
        if(_isMoving){
            if (inputX > 0 & !m_FacingRight )
            Flip();
        else if (inputX < 0 & m_FacingRight ) 
            Flip();
        }

        _animations.IsMoving =_isMoving;  
    }
     
    private void Jump(){
        
        m_body2d.AddForce(transform.up * _jumpForce,ForceMode2D.Impulse);
       
    }
    private void Flip()
	{
		m_FacingRight = !m_FacingRight;
		transform.Rotate(0f, 180f, 0f);
	}
    public void TakePlayerDamage(float damage){
        
        _currentHealth -=damage;
    
        if(_currentHealth<=0){
            Die();
        }
        _healtBar.SetHealth(_currentHealth);
    }
    private void Die(){
        Destroy(gameObject);
        Debug.Log("Player Die");
    }


}
