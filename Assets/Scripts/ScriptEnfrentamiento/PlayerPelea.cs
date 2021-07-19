using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPelea : MonoBehaviour
{
    //This script is an example on how to use the linear indicator asset

    public LinearIndicator linearIndicator;


    public float minValue, maxValue;
    public float currentValue;
    float defensaActual = 0;
    float defensaEnemiga = 0;

    void Start()
    {
        linearIndicator.SetupIndicator(minValue, maxValue);

        linearIndicator.SetValue(currentValue);


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (currentValue <= 0)
        {
            Debug.Log("Ganaste");
        }

    }

    public void ataque()
    {
        if(defensaEnemiga == 0)
        {
            currentValue = currentValue - 30;
        } else

        {
            currentValue = currentValue - (30 / defensaEnemiga * .2f);
        }
        linearIndicator.SetValue(currentValue);

        ManagerScn.turnoEnemigo = true;
        ManagerScn.turnoPlayer = false;
    }

    public void defensa()
    {
       
    }
}