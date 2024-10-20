using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    // Start is called before the first frame update
    private Light flashlight;
    void Start()
    {
        flashlight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)) 
        {
            if(flashlight != null)
            {
                flashlight.enabled = !flashlight.enabled;
            }
        }
    }
}
