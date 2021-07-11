using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovA : MonoBehaviour
{
    public static bool movA = true;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("pared"))
        {
            movA = false;
        }
        if (other.gameObject.CompareTag("arbusto") || other.gameObject.CompareTag("piso"))
        {
            movA = true;
        }
    }

}
