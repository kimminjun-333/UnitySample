using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

[RequireComponent(typeof(Animator), typeof(RigBuilder))]
public class PlayerAction : MonoBehaviour
{
    Animator animator;
    private Rig rig;
    private WaitUntil untilReload;

    public AnimationClip reloadClip;

    private bool isReloading = false;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rig = GetComponent<RigBuilder>().layers[0].rig;
    }

    private void Start()
    {
        untilReload = new WaitUntil(() => isReloading);
        StartCoroutine(ReloadCoroutine());
    }

    private void Update()
    {
        if(isReloading == false && Input.GetKeyDown(KeyCode.R))
        {
            //재장전
            rig.weight = 0f;
            isReloading = true;
            animator.SetTrigger("Reload");
        }
    }

    public void OnReloadEnd()//외부에서 제작된 FBX 내장 애니메이션에도 이벤트를 추가할수 있는데
    {
        //rig.weight = 1f;   //문제는 animation Rig는 애니메이션 이벤트로 weight를 조절할수 없음
        //isReloading = false;

    }

    IEnumerator ReloadCoroutine()
    {
        while(true)
        {
            yield return untilReload;//Reload가 true가 될때까지 기다림
            yield return new WaitForSeconds(reloadClip.length);
            isReloading = false;
            rig.weight = 1f;
        }
    }

}
