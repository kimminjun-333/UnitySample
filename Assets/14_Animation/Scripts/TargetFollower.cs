using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFollower : MonoBehaviour
{
    public Transform target;

    public bool followPosition;
    public bool followRotation;

    private void Update()
    {
        if(target == null) return;
        
        if(followPosition == true) transform.position = target.position;
        
        if(followRotation == true) transform.rotation = target.rotation;
        
    }


}
