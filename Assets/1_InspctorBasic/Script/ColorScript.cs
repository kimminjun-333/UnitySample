using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[Serializable]
public class Colors
{
    public Color targetColor;//������ Inspector

    public Renderer targetRanderer;//Inspector â�� ������Ʈ �巡���ؼ� �ֱ�

    public Transform targetTransform;//Inspector â�� ������Ʈ �巡���ؼ� �ֱ�

    public Vector3 position = Vector3.zero;//������Ʈ ������ ��ǥ
    public Vector3 Scale = Vector3.zero;//������Ʈ ũ��
    public Vector3 rot = Vector3.zero;//������Ʈ ȸ�� ����
}

public class ColorScript : MonoBehaviour
{
   public List<Colors> colors;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Colors C in colors)
        {
            C.targetRanderer.material.color = C.targetColor;//������ ���� Ÿ�ٿ�����Ʈ�� ����
            C.targetTransform.localPosition = C.position;//������ǥ���� ��ǥ��ŭ �̵�
            C.targetTransform.localScale = C.Scale;//���ý�����
            C.targetTransform.localEulerAngles = C.rot;//���� ȸ��
        }
    }
            //targetRanderer.material.color = targetColor;
            //targetTransform.localPosition = position;
            //targetTransform.localScale = Scale;
            //targetTransform.localEulerAngles = rot;
    // Update is called once per frame
    void Update()
    {
        
    }
}
