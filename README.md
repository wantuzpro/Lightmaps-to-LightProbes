# Lightmaps-to-LightProbes
A simple tool for changing GI of static objects from Lightmaps to Light Probes. The tool is designed for Unity HDRP
___________________________

> The script is useful in situations when there are many objects on which you need to change the GI

```
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

```
