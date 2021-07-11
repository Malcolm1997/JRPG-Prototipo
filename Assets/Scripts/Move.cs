using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class Move : MonoBehaviour
{
    

    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (position == transform.position)
        {
            if (Input.GetKeyDown(KeyCode.D) && MovD.movD)
            {
                position += new Vector3(1, 0, 0);
            }
            else if (Input.GetKeyDown(KeyCode.A) && MovA.movA)
            {
                position += new Vector3(-1, 0, 0);
            }
            else if (Input.GetKeyDown(KeyCode.W) && MovW.movW)
            {
                position += new Vector3(0, 0, 1);
            }
            else if (Input.GetKeyDown(KeyCode.S) && MovS.movS)
            {
                position += new Vector3(0, 0, -1);
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, position, 2f * Time.deltaTime);
    }
}
