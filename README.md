# Lightmaps-to-LightProbes
A simple tool for changing GI of static objects from Lightmaps to Light Probes. The tool is designed for Unity HDRP
___________________________

The script is useful in situations when there are many objects on which you need to change the GI

```c#

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

```
