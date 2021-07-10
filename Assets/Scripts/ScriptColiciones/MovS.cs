using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovS : MonoBehaviour
{
    public static bool movS = true;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("pared"))
        {
            movS = false;
        }
        if (other.gameObject.CompareTag("arbusto"))
        {
            movS = true;
        }
    }
}
