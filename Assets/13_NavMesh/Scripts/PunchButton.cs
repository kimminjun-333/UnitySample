using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class PunchButton : MonoBehaviour
{
    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(Shake);

    }

    Tweener punchTween;

    private void Punch()
    {
        if(punchTween != null)
        {
            punchTween.Complete();//Ʈ���� �������̸� Ʈ���� ������ ����
        }

        Vector3 punchSize = new Vector3(0.1f, 0.1f, 0.1f);

        punchTween = transform.DOPunchScale(punchSize, 0.5f);
    }
    private void Shake()
    {
        if (punchTween != null)
        {
            punchTween.Complete();//Ʈ���� �������̸� Ʈ���� ������ ����
        }

        punchTween = transform.DOShakePosition(0.5f, 10f, 80);
    }

}
