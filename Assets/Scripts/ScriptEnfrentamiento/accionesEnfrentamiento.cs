using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class accionesEnfrentamiento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ataque()
    {

    }

    public void defensa()
    {

    }

    public void pasarTurno()
    {

    }

    public void huir()
    {
        if(Random.Range(1,3) < 2)
        {
            Debug.Log("No lograste escapar");
        } else
        {
            SceneManager.LoadScene("Main");
        }
    }
}
