using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBehavior : MonoBehaviour
{
    public Transform _followTarget;
    [SerializeField, Range(0f,1f)] float _parallaxStrenght = 0.1f;
    public bool _disableVerticalParallax;
    Vector3 targetPreviousPosition;

    // Start is called before the first frame update
    void Start()
    {
        if(!_followTarget)
            _followTarget=Camera.main.transform;
        targetPreviousPosition = _followTarget.position;
    }

    // Update is called once per frame
    void Update()
    {
        var delta = _followTarget.position = targetPreviousPosition;
        if(_disableVerticalParallax)
            delta.y = 0;
        targetPreviousPosition = _followTarget.position;
        transform.position+= delta* _parallaxStrenght;
    }
}
