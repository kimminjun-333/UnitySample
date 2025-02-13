using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetBundleTest : MonoBehaviour
{
    private void Start()
    {
        string bundlePath = "./Bundle";
        string targetBundle = "prefabs/bat";
        string assetName = "Bat";

        //��� ������ �ε�. ��� ������ ���� ������ ��ä�θ� �ε��� �� ����
        //LoadFromFile : ���� ������ �ִ� �ý��� ��θ� ���� �ؾ���
        AssetBundle assetBun = AssetBundle.LoadFromFile($"{bundlePath}/{targetBundle}");
        
        if (assetBun == null)
        {
            Debug.LogError("��� ���� ���� ����");
            return;
        }
        //��� ������ ���� : ���Ӽ��� �ִ� ������ �ε����� ������ �������� ���� �� �ִ�
        AssetBundle.LoadFromFile($"{bundlePath}/material/monster");
        AssetBundle.LoadFromFile($"{bundlePath}/modle/bat");
        AssetBundle.LoadFromFile($"{bundlePath}/texture");

        GameObject batPrefab = assetBun.LoadAsset<GameObject>($"{assetName}");

        GameObject instance = Instantiate(batPrefab);
    }

}
