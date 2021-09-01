using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    public float TimeToWait = 5.0f;
    MeshRenderer rendererr;
    Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rendererr = GetComponent<MeshRenderer>();
        rendererr.enabled = false;
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > TimeToWait)
        {
            rendererr.enabled = true;
            rigidBody.useGravity = true;
        }

    }
}
