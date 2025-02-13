using System.IO;
using UnityEditor;
using UnityEngine;
//AssetBundle 을 빌드해주는 역할
//AssetBundle : 개발자가 프로젝트에 활용될 리소스를 유니티의
//바이너리 데이터 생성 방식과 동일한 방식으로 직접 생성해서 활용할 수 있도록 하는 기능
//필수적으로 어셋 번들을 따로 유니티 바이너리 생성 방식으로 빌드를 해야한다
public class AssetBundleBuilder
{
    [MenuItem("에셋번들/빌드하기")]
    static void AssetBundleBuulder()
    {
        string bundlePath = "./Bundle";//%프로젝트 경로%/Bundle
        if (!Directory.Exists(bundlePath))
        {
            //번들을 빌드할 경로에 폴더가 존재하지않으면 폴더 생성
            Directory.CreateDirectory(bundlePath);
        }
        AssetBundleManifest manifest = BuildPipeline.BuildAssetBundles(bundlePath, 
            BuildAssetBundleOptions.None, EditorUserBuildSettings.activeBuildTarget);
        if (manifest)
        {
            //빌드 성공
            EditorUtility.DisplayDialog("번들 빌드", "에셋 번들을 빌드하였습니다", "확인");
        }
        else
        {
            //빌드 실패
            EditorUtility.DisplayDialog("번들 빌드", "에셋 번들을 빌드하지 못했습니다", "확인");
        }
    }

}
