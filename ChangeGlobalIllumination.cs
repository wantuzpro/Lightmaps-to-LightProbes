using UnityEngine;
using UnityEditor;

public class ChangeGlobalIllumination : EditorWindow
{
    private int selectedMode = 0;
    private readonly string[] modeOptions = { "Lightmaps", "LightProbes" };

    [MenuItem("Tools/Global Illumination Changer")]
    public static void ShowWindow()
    {
        var window = GetWindow<ChangeGlobalIllumination>("GI Changer");
        window.minSize = new Vector2(200, 100);
        window.maxSize = new Vector2(200, 100);
    }
    private void OnGUI()
    {
        GUILayout.Label("Select global illumination mode", EditorStyles.boldLabel);
        selectedMode = EditorGUILayout.Popup("Mode:", selectedMode, modeOptions);
        GUILayout.Space(10);

        if (GUILayout.Button("Apply"))
        {
            ApplyGlobalIllumination();
        }
        if (GUILayout.Button("Show MeshRenderer count"))
        {
            int count = FindObjectsOfType<MeshRenderer>().Length;
            EditorUtility.DisplayDialog("Information", $"Found {count} MeshRenderer objects in the scene.", "OK");
        }
    }
    private void ApplyGlobalIllumination()
    {
        MeshRenderer[] renderers = FindObjectsByType<MeshRenderer>(FindObjectsInactive.Include, FindObjectsSortMode.None);
        foreach (MeshRenderer renderer in renderers)
        {
            if (selectedMode == 0)
            {
                renderer.receiveGI = ReceiveGI.Lightmaps;
            }
            else
            {
                renderer.receiveGI = ReceiveGI.LightProbes;
            }
        }
        EditorUtility.DisplayDialog("Global Illumination", $"Global Illumination changed to {modeOptions[selectedMode]} for {renderers.Length} objects.", "OK");
    }
}
