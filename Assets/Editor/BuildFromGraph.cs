using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.AssetGraph;

public class BuildFromGraph {

    [MenuItem("Demo/Build")]
	static void Build () {
        AssetGraphUtility.ExecuteGraph("Assets/Workflow/AB.asset");
	}
}
