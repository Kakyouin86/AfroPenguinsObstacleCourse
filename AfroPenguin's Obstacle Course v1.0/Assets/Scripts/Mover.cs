using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float yValue = 0.0f;
    public float moveSpeed = 10.0f;

    void Start()
    {

    }

    private void Update()
    {
        MovePlater();
    }

    void MovePlater()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        //Debug.Log(xValue);
        //Debug.Log(zValue);
        transform.Translate(xValue, yValue, zValue);
    }

}
