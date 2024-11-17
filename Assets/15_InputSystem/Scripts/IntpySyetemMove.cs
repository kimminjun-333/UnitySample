using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController),typeof(Animator), typeof(PlayerInput))]
public class IntpySyetemMove : MonoBehaviour
{
    CharacterController charCtrl;
    Animator animator;

    public float WalkSpeed;
    public float runSpeed;

    Vector2 inpuValue;

    public InputActionAsset controlDefine;

    InputAction moveAction;

    private void Awake()
    {
        charCtrl = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        controlDefine = GetComponent<PlayerInput>().actions;
        moveAction = controlDefine.FindAction("Move");
    }

    private void OnEnable()
    {
        moveAction.performed += OnMoveEvent;
        moveAction.canceled += OnMoveEvent;
    }

    private void OnDisable()
    {
        moveAction.performed -= OnMoveEvent;
        moveAction.canceled -= OnMoveEvent;
    }

    public void OnMoveEvent(InputAction.CallbackContext context)
    {
        print($"OnMoveEvent 호출, context : {context.ReadValue<Vector2>()}");
        inpuValue = context.ReadValue<Vector2>();
    }

    private void OnMove(InputValue value)
    {
        //value.isPressed

        inpuValue = value.Get<Vector2>();

        print($"OnMove 호출, 파라미터 : {inpuValue}");

    }

    private void Update()
    {
        Vector3 inputmoveDir = new Vector3(inpuValue.x, 0, inpuValue.y) * WalkSpeed;
        Vector3 actualMoveDir = transform.TransformDirection(inputmoveDir);

        Vector3 velo = Vector3.zero;
        charCtrl.Move(actualMoveDir * Time.deltaTime);
        //Vector2 smooth = Vector2.SmoothDamp(inpuValue.x, inpuValue.y);

        animator.SetFloat("Xdir", inpuValue.x);
        animator.SetFloat("Ydir", inpuValue.y);
        animator.SetFloat("Speed", inpuValue.magnitude);

    }


}
