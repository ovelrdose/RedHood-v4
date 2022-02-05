using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitCamera : MonoBehaviour
{
    [SerializeField]float _rightLimit;
    [SerializeField]float _leftLimit;
    [SerializeField]float _upperLimit;
    [SerializeField]float _bottonLimit;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,_leftLimit,_rightLimit),
        Mathf.Clamp(transform.position.y,_bottonLimit,_upperLimit),
        transform.position.z
        );
    }
    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(new Vector2(_leftLimit,_upperLimit),new Vector2(_rightLimit,_upperLimit));
    }
}
