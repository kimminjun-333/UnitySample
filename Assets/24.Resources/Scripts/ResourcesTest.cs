using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesTest : MonoBehaviour
{
    //public GameObject prefab;

    private IEnumerator Start()
    {
        //yield return new WaitForSeconds(30f);
        //���ҽ� �Ŵ����� ���� GameObject�� Material�� �ε�
        GameObject prefab = Resources.Load<GameObject>("Prefabs/TestPrefab");

        GameObject instance = Instantiate(prefab);

        yield return new WaitForSeconds(3f);

        Material mat = Resources.Load<Material>("Materials/TestMaterial");

        instance.GetComponent<Renderer>().material = mat;

        yield return new WaitForSeconds(3f);

        Resources.UnloadAsset(mat);
        print("mat ��ε� �Ϸ�");

        Resources.UnloadAsset(prefab);
        //prefab�� unloadAsset�� ���� ��������� ��ε� �� �� ����
        print("Prefab ��ε� �Ϸ�");

        //yield return Resources.UnloadUnusedAssets();
        //print("�Ⱦ��� ���ҽ� ��ε尡 �Ϸ�Ǿ���");
    }
}
