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
            //������
            rig.weight = 0f;
            isReloading = true;
            animator.SetTrigger("Reload");
        }
    }

    public void OnReloadEnd()//�ܺο��� ���۵� FBX ���� �ִϸ��̼ǿ��� �̺�Ʈ�� �߰��Ҽ� �ִµ�
    {
        //rig.weight = 1f;   //������ animation Rig�� �ִϸ��̼� �̺�Ʈ�� weight�� �����Ҽ� ����
        //isReloading = false;

    }

    IEnumerator ReloadCoroutine()
    {
        while(true)
        {
            yield return untilReload;//Reload�� true�� �ɶ����� ��ٸ�
            yield return new WaitForSeconds(reloadClip.length);
            isReloading = false;
            rig.weight = 1f;
        }
    }

}
