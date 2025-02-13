using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class AssetBundleDownloadTest : MonoBehaviour
{
    public string url;

    private IEnumerator Start()
    {
        //웹으로부터 에셋 번들을 다운로드 할때 버전을 사용하지 않으면 로컬에
        //캐시파일을 생성하지 않고 메번 다시 다운로드
        //UnityWebRequest www = UnityWebRequestAssetBundle.GetAssetBundle(url, 0, 0);

        //버전을 사용하면 로컬 캐쉬로부터 불러오므로 최초 다운로드 이후로는 로드가 거의 즉시 완료됨
        //로컬 캐시 파일은 에디터의 경우 ~/AppData/LocalLow/Unity/회사명_프로젝트명 폴더 안에 생성
        UnityWebRequest www = UnityWebRequestAssetBundle.GetAssetBundle(url, version: 0, crc: 0);

        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.Success)
        {
            //에셋번들 다운로드 완료

            //웹리퀘스트의 결과(Response)로부터 어셋 번들을 로드
            AssetBundle modelBundle = DownloadHandlerAssetBundle.GetContent(www);

            AssetBundle prefabBundle = AssetBundle.LoadFromFile("./Bundle/prefabs/bat");
            AssetBundle.LoadFromFile("./Bundle/material/monster");
            AssetBundle.LoadFromFile("./Bundle/Texture");

            GameObject prefab = prefabBundle.LoadAsset<GameObject>("Bat");

            Instantiate(prefab);
        }
        else
        {
            print($"번들 로드 실패 : {www.error}");
            yield break;
        }

        yield return null;
    }
}
