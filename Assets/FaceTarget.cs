using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceTarget : MonoBehaviour
{

    public Transform target;

    // start is called before the first frame update
    void Start()
    {
        transform.LookAt(target.position); 
    }
}
