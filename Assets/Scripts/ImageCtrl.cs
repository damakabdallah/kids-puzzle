using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageCtrl : MonoBehaviour {


    int[] RandomAngles = new int[] { 90, -90, 180 };
    WinCondition CanvOfWin;

    void Start () {
        int i = Random.Range(0, 2);
        transform.Rotate(0, 0, RandomAngles[i]);
        CanvOfWin = GameObject.Find("background").GetComponent<WinCondition>();
	}
	
    private void OnMouseDown()
    {
        if(CanvOfWin.Canv.activeInHierarchy==false)
          transform.Rotate(0, 0, 90);
    }
}
