using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VersionLogger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"App version-> {Application.version}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
