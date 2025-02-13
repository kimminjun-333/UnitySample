using System.IO;
using UnityEditor;
using UnityEngine;
//AssetBundle �� �������ִ� ����
//AssetBundle : �����ڰ� ������Ʈ�� Ȱ��� ���ҽ��� ����Ƽ��
//���̳ʸ� ������ ���� ��İ� ������ ������� ���� �����ؼ� Ȱ���� �� �ֵ��� �ϴ� ���
//�ʼ������� ��� ������ ���� ����Ƽ ���̳ʸ� ���� ������� ���带 �ؾ��Ѵ�
public class AssetBundleBuilder
{
    [MenuItem("���¹���/�����ϱ�")]
    static void AssetBundleBuulder()
    {
        string bundlePath = "./Bundle";//%������Ʈ ���%/Bundle
        if (!Directory.Exists(bundlePath))
        {
            //������ ������ ��ο� ������ �������������� ���� ����
            Directory.CreateDirectory(bundlePath);
        }
        AssetBundleManifest manifest = BuildPipeline.BuildAssetBundles(bundlePath, 
            BuildAssetBundleOptions.None, EditorUserBuildSettings.activeBuildTarget);
        if (manifest)
        {
            //���� ����
            EditorUtility.DisplayDialog("���� ����", "���� ������ �����Ͽ����ϴ�", "Ȯ��");
        }
        else
        {
            //���� ����
            EditorUtility.DisplayDialog("���� ����", "���� ������ �������� ���߽��ϴ�", "Ȯ��");
        }
    }

}
