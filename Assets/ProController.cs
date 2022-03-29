using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ProController : MonoBehaviour
{
    GameObject FPSController = null;
    
    // Start is called before the first frame update
    void Start()
    {
       for (int i =0; i < Gamepad.all.Count; i++)
        {
            Debug.Log(Gamepad.all[i].name);
        }

        FPSController = GameObject.Find("FPSController");
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamepad.all.Count > 0)
        {
            FPSController.transform.position += Vector3.left * Time.deltaTime * 5f;
        }
    }
}
