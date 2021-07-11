using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovW : MonoBehaviour
{
    public static bool movW = true;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("pared"))
        {
            movW = false;
        }
        if (other.gameObject.CompareTag("arbusto") || other.gameObject.CompareTag("piso"))
        {
            movW = true;
        }
    }
}
