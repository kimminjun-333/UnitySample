using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesTest : MonoBehaviour
{
    //public GameObject prefab;

    private IEnumerator Start()
    {
        //yield return new WaitForSeconds(30f);
        //리소스 매니저를 통해 GameObject와 Material을 로드
        GameObject prefab = Resources.Load<GameObject>("Prefabs/TestPrefab");

        GameObject instance = Instantiate(prefab);

        yield return new WaitForSeconds(3f);

        Material mat = Resources.Load<Material>("Materials/TestMaterial");

        instance.GetComponent<Renderer>().material = mat;

        yield return new WaitForSeconds(3f);

        Resources.UnloadAsset(mat);
        print("mat 언로드 완료");

        Resources.UnloadAsset(prefab);
        //prefab은 unloadAsset을 통해 명시적으로 언로드 할 수 없음
        print("Prefab 언로드 완료");

        //yield return Resources.UnloadUnusedAssets();
        //print("안쓰는 리소스 언로드가 완료되었음");
    }
}
