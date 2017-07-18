using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.AssetBundles.GraphTool;

public class BuildFromGraph {

    [MenuItem("Demo/Build")]
	static void Build () {
        AssetBundleGraphUtility.ExecuteGraph("Assets/Workflow/AB.asset");
	}
}
