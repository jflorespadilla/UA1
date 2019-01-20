using System.Collections;
using UnityEngine;

public class BaseicUI : MonoBehaviour {

    private void OnGUI() {
        if (GUI.Button(new Rect(10, 10, 40, 20), "TEST")) {
            Debug.Log("Test button");
        }
    }
}
