using UnityEngine;
using UnityEditor;

public class ChangeGlobalIllumination : MonoBehaviour
{
    [MenuItem("Tools/Change to Lightmaps")]
    static void ChangeGILightmaps()
    {
        MeshRenderer[] renderers = FindObjectsOfType<MeshRenderer>();

        foreach (MeshRenderer renderer in renderers)
        {
            renderer.receiveGI = ReceiveGI.Lightmaps;
        }

        Debug.Log("Global Illumination changed to Lightmaps");
    }

    [MenuItem("Tools/Change to LightProbes")]
    static void ChangeGILightProbes()
    {
        MeshRenderer[] renderers = FindObjectsOfType<MeshRenderer>();

        foreach (MeshRenderer renderer in renderers)
        {
            renderer.receiveGI = ReceiveGI.LightProbes;
        }

        Debug.Log("Global Illumination changed to LightProbes");
    }
}
