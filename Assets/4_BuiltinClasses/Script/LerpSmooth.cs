using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpSmooth : MonoBehaviour
{
    public Transform followTarget;
    public float mobeSpeed;


    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, followTarget.position, 
            Time.deltaTime * mobeSpeed);//������Ʈ���󰡱�
        //0.02 * 3 = 0.05~0.06
    }
}
