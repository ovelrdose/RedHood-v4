using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunFoxAway : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D _foxRB; 
    private GameObject _player;
    private bool _facingRight = true;
    private Animator FoxAnim; 
    public Transform RunAwayPoint;
    public float _speedAway = 1f;
    public bool RunFox = false;
    void Start()
    {
        _foxRB = GetComponent<Rigidbody2D>();
        _player = GameObject.Find("Player"); 
        FoxAnim = GetComponent<Animator>();
        FoxAnim.SetBool("FoxIsMove",false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(RunFox){
            FoxAnim.SetBool("FoxIsMove",true);
            transform.position = Vector3.MoveTowards(transform.position, RunAwayPoint.transform.position, _speedAway*Time.deltaTime);
           if(_facingRight){
                    _foxRB.transform.Rotate(0f, 180f, 0f);
                    _facingRight = !_facingRight;
                }  
        }
        if(transform.position == RunAwayPoint.transform.position){
            FoxAnim.SetBool("FoxIsMove",false);
            Destroy(gameObject);
        }
       
        
    }
}
