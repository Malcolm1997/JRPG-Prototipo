using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovD : MonoBehaviour
{
    public static bool movD = true;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("pared"))
        {
            movD = false;
        }
        if (other.gameObject.CompareTag("arbusto"))
        {
            movD = true;
        }
    }
}
