using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UGUIInteractionTest : MonoBehaviour
{
    //Button 컴포넌트의 OnClick() 이벤트에 할당하여 해당 버튼이 클릭 될 때마다 호출되도록
    //유니티엔진이 Inpector에 할당된 대로 의존성을 주입해준다
    //Inspector에서 해당 함수를 참조하려면 접근지정자가 public이어야 함
    public void ButtonClick()//이 함수는 버튼이 클릴될때 호출
    {
        print("버튼이 클릭됨");
    }

    public void ButtonClickWithParam(string param)
    {
        print($"버튼 클릭됨 파라미터 : {param}");
    }

    public void ButtonClickWithFloatparam(float param)
    {
        print($"버튼 클릭됨 파라미터 : {param}");
    }

    public void ButtonClickWithBoolParam(bool param)
    {
        print($"버튼 클릭됨 파라미터 : {param}");
    }

}
