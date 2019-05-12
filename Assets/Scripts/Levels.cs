using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Levels : MonoBehaviour {
    [HideInInspector]
    public TextMeshProUGUI  TMP;

	// Use this for initialization
	void Start () {
        TMP = gameObject.GetComponentInChildren<TextMeshProUGUI>();
	}

    public void LoadLevel()
    {
        SceneManager.LoadScene("Level " + TMP.text);
    }
}
