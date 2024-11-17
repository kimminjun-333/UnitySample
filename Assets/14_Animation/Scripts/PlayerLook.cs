using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;


public class PlayerLook : MonoBehaviour
{
    public Transform cameraRig;

    public float mouseSensivity;//감도

    private float rigAngle = 0f;

    private void Update()
    {
        

        float mouseX = Input.GetAxis("Mouse X");//mouse가 움직인 delta
        float mouseY = Input.GetAxis("Mouse Y");

        //마우스의 좌우 움직임에 맞춰 캐릭터의 Transform을 Rotate
        transform.Rotate(0, mouseX * mouseSensivity * Time.deltaTime, 0);

        rigAngle -= mouseY * mouseSensivity * Time.deltaTime;

        //카메라 리그의 x축 각도를 제한
        rigAngle = Mathf.Clamp(rigAngle, -90f, 90f);

        //제한된 각도만큼 카메라 리그의 x축 각도를 변경
        cameraRig.localEulerAngles = new Vector3(rigAngle, 0, 0);

        //마우스의 상하 움직임에 맞춰 카메라 리그의 Transform을 Rotate
        //cameraRig.Rotate(-mouseY * mouseSensivity * Time.deltaTime, 0, 0);


    }


}
