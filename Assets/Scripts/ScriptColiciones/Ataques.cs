using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataques : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("arbusto"))
        {
            if (UnityEngine.Random.Range(1, 5) < 4)
            {
                Debug.Log("No hay ataque");
            }
            else
            {
                Debug.Log("Hay ataque");
            }
        }
    }
}
