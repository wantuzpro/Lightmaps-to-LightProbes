using UnityEngine;
using UnityEditor;

public class ChangeGlobalIllumination : MonoBehaviour
{
    [MenuItem("Tools/Change Global Illumination")]
    static void ChangeGI()
    {
        MeshRenderer[] renderers = FindObjectsOfType<MeshRenderer>();

        foreach (MeshRenderer renderer in renderers)
        {
            renderer.receiveGI = ReceiveGI.LightProbes;
        }

        Debug.Log("Global Illumination changed to Light Probes for all objects");
    }
}
