using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class BackgroundsFlow1 : MonoBehaviour
    {

        public float flowSpeed;

        void Update()
        {
            //transform : 이 컴포넌트가 부착된 오브젝트의 Transform 컴포넌트
            //Transform.Translate : 현재 position에서 파라미터의 Vector값을 Position을 이동
            //Vector3.down = new Vector3(0, -1, 0)과 같음
            transform.Translate(Vector3.down * Time.deltaTime * flowSpeed);
            if (transform.position.y < -2.55f)
                transform.position = Vector3.zero;

        }
    }

