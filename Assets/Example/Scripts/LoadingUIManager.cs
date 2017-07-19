using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingUIManager : MonoBehaviour {

    public GameObject errorUI;

    void OnSceneLoadError() {
        errorUI.SetActive (true);
    }

    void OnSceneLoaded() {
        gameObject.SetActive (false);
    }
}
