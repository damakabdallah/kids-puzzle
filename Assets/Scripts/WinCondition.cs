using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour {

    public GameObject[] Images= new GameObject[6];
    public GameObject Canv;

	
	void Update () {
        if (Images[0].transform.rotation.z == 0 &&
            Images[1].transform.rotation.z == 0 &&
            Images[2].transform.rotation.z == 0 &&
            Images[3].transform.rotation.z == 0 &&
            Images[4].transform.rotation.z == 0 &&
            Images[5].transform.rotation.z == 0 )
        {
            Canv.SetActive(true);
        }
    }
}
