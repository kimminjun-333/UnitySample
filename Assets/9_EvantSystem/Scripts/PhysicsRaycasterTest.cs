using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[Serializable]
public class ShapeDate
{
    public enum Shape
    {
        Cube,
        Capsule,
        Sphere
    }
    public Shape shape;
    public float scale;
    public Color color;
}

public class PhysicsRaycasterTest : MonoBehaviour, IPointerEnterHandler, 
    IPointerExitHandler, IPointerMoveHandler
{
    public ShapeDate shapeData;

    public void OnPointerEnter(PointerEventData eventData)
    {
        EventSystemTestManager.instance.ShowTooltip(shapeData);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        EventSystemTestManager.instance.HideTooltip();
    }
    
    public void OnPointerMove(PointerEventData eventData)
    {
        EventSystemTestManager.instance.tooltip.GetComponent<RectTransform>().anchoredPosition
            = eventData.position;
        //eventData.Position :
        //screen�� ���� �Ʒ� ���� (0,0)�� ��ǥ �������� ���콺 �������� ��ġ
    }

    private void Start()
    {
        GetComponentInParent<Renderer>().material.color = shapeData.color;
        transform.parent.localScale = Vector3.one * shapeData.scale;
    }
    

}
