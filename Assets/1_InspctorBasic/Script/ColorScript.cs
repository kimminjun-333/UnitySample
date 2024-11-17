using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[Serializable]
public class Colors
{
    public Color targetColor;//색변경 Inspector

    public Renderer targetRanderer;//Inspector 창에 오브젝트 드래그해서 넣기

    public Transform targetTransform;//Inspector 창에 오브젝트 드래그해서 넣기

    public Vector3 position = Vector3.zero;//오브젝트 포지션 좌표
    public Vector3 Scale = Vector3.zero;//오브젝트 크기
    public Vector3 rot = Vector3.zero;//오브젝트 회전 각도
}

public class ColorScript : MonoBehaviour
{
   public List<Colors> colors;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Colors C in colors)
        {
            C.targetRanderer.material.color = C.targetColor;//설정한 색을 타겟오브젝트에 적용
            C.targetTransform.localPosition = C.position;//로컬좌표에서 좌표만큼 이동
            C.targetTransform.localScale = C.Scale;//로컬스케일
            C.targetTransform.localEulerAngles = C.rot;//로컬 회전
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
