using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator), typeof(RigBuilder))]
public class InputSystemAction : MonoBehaviour
{
    Animator animator;
    Rig rig;
    
    private bool isAction;
    private bool isfire;
    public AnimationClip reloadClip;
    public AnimationClip fireClip;
    public AnimationClip grenadeClip;
    public Gun gun;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rig = GetComponent<RigBuilder>().layers[0].rig;
    }

    private void Start()
    {
        //WaitUntil untilReload = new WaitUntil(() => isReloading);
        //while (true)
        //{
        //    yield return untilReload;
        //    yield return new WaitForSeconds(reloadClip.length);
        //    isReloading = false;
        //    rig.weight = 1.0f;
        //}
        //StartCoroutine(reload());
        //StartCoroutine(fire());
        //StartCoroutine(grenade());
    }

    private void Update()
    {
        if (isAction == true && isfire == false)
        {
            rig.weight = 0f;
        }
        else if (isAction == false || isfire == true)
        {
            rig.weight = 1f;
        }
    }

    public void OnReloadEvent(InputAction.CallbackContext context)
    {
        if (isAction) return;
        if (context.performed)
        {
            rig.weight = 0f;
            isAction = true;
            animator.SetTrigger("Reload");
        }
    }

    private void OnReload(InputValue value)
    {
        Reload();
    }

    private void Reload()
    {
        if (isAction == true) return;
        rig.weight = 0f;
        isAction = true;
        animator.SetTrigger("Reload");
    }
    public void IsActionOff()
    {
        isAction = false;
    }

    public void OnReloadEnd()
    {
        IsActionOff();
    }

    //private IEnumerator reload()
    //{
    //    WaitUntil untilReload = new WaitUntil(() => isAction);
    //    while (true)
    //    {
    //        yield return untilReload;
    //        yield return new WaitForSeconds(reloadClip.length);
    //        isAction = false;
    //        rig.weight = 1.0f;
    //    }
    //}

    private void OnFire(InputValue value)
    {
        if (isAction == true) return;
        //print($"OnFrie 호출, isPressed : {value.isPressed}");
        //isAction = true;
        isfire = true;
        isAction = true;
        animator.SetTrigger("Fire");
        gun.BulletSoot();
    }

    public void OnFireEnd()
    {
        IsActionOff();
        isfire = false;
    }

    //private IEnumerator fire()
    //{
    //    WaitUntil untilfire = new WaitUntil(() => isFire);
    //    while (true)
    //    {
    //        yield return untilfire;
    //        yield return new WaitForSeconds(fireClip.length);
    //        isFire = false;
    //        rig.weight = 1.0f;
    //    }
    //}

    private void OnGrenade(InputValue value)
    {
        if (isAction == true) return;
        //print($"OnFrie 호출, isPressed : {value.isPressed}");
        isAction = true;
        animator.SetTrigger("Grenade");
    }

    public void OnGrenadeEnd()
    {
        IsActionOff();
    }

    //private IEnumerator grenade()
    //{
    //    WaitUntil untilgrenade = new WaitUntil(() => isGrenade);
    //    while (true)
    //    {
    //        yield return untilgrenade;
    //        yield return new WaitForSeconds(grenadeClip.length);
    //        isGrenade = false;
    //        rig.weight = 1.0f;
    //    }
    //}


}
