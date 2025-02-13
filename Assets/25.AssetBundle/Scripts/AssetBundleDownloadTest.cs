using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class AssetBundleDownloadTest : MonoBehaviour
{
    public string url;

    private IEnumerator Start()
    {
        //�����κ��� ���� ������ �ٿ�ε� �Ҷ� ������ ������� ������ ���ÿ�
        //ĳ�������� �������� �ʰ� �޹� �ٽ� �ٿ�ε�
        //UnityWebRequest www = UnityWebRequestAssetBundle.GetAssetBundle(url, 0, 0);

        //������ ����ϸ� ���� ĳ���κ��� �ҷ����Ƿ� ���� �ٿ�ε� ���ķδ� �ε尡 ���� ��� �Ϸ��
        //���� ĳ�� ������ �������� ��� ~/AppData/LocalLow/Unity/ȸ���_������Ʈ�� ���� �ȿ� ����
        UnityWebRequest www = UnityWebRequestAssetBundle.GetAssetBundle(url, version: 0, crc: 0);

        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.Success)
        {
            //���¹��� �ٿ�ε� �Ϸ�

            //��������Ʈ�� ���(Response)�κ��� ��� ������ �ε�
            AssetBundle modelBundle = DownloadHandlerAssetBundle.GetContent(www);

            AssetBundle prefabBundle = AssetBundle.LoadFromFile("./Bundle/prefabs/bat");
            AssetBundle.LoadFromFile("./Bundle/material/monster");
            AssetBundle.LoadFromFile("./Bundle/Texture");

            GameObject prefab = prefabBundle.LoadAsset<GameObject>("Bat");

            Instantiate(prefab);
        }
        else
        {
            print($"���� �ε� ���� : {www.error}");
            yield break;
        }

        yield return null;
    }
}
