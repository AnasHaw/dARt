using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyTxt : MonoBehaviour
{

    public static string readyTxt = "";

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        GUI.Box(new Rect(1100, 70, 100, 20), readyTxt);
    }

}