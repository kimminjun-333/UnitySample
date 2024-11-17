using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputSystemLook : MonoBehaviour
{
    public float mouseSensivity;
    public Transform cameraRig;
    private float rigAngle = 0f;

    public void OnLookEvent(InputAction.CallbackContext context)
    {
        print($"OnMoveEvent 호출, context : {context.ReadValue<Vector2>()}");
        //inpuValue = context.ReadValue<Vector2>();
        Look(context.ReadValue<Vector2>());
    }

    private void OnLook(InputValue value)
    {
        print($"OnLook 호출, 파라미터 : {value.Get<Vector2>()}");

        if (false == SimpielMouseControl.isFocusing) return;

        Vector2 mouseDelta = value.Get<Vector2>();

        Look(mouseDelta);

    }

    private void Look(Vector2 mouseDelta)
    {
        transform.Rotate(0, mouseDelta.x * mouseSensivity * Time.deltaTime, 0);
        rigAngle -= mouseDelta.y * mouseSensivity * Time.deltaTime;
        rigAngle = Mathf.Clamp(rigAngle, -90f, 90f);
        cameraRig.localEulerAngles = new Vector3(rigAngle, 0, 0);
    }    


}
