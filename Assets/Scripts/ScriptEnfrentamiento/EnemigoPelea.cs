using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoPelea : MonoBehaviour
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
            Debug.Log("Perdiste");
        }

        float valorRandom = Random.Range(0, 10); 

        if(valorRandom < 5 && ManagerScn.turnoPlayer == false)
        {
            ataque();
            ManagerScn.turnoPlayer = true;

        } else if (valorRandom < 9 && ManagerScn.turnoPlayer == false)
        {
            enemiDefense();
            ManagerScn.turnoPlayer = true;

        }


    }

    public void ataque()
    {
        if (defensaEnemiga == 0)
        {
            currentValue = currentValue - 20;
        }
        else
        {
            currentValue = currentValue - (20 / (defensaActual * .2f));
        }
        linearIndicator.SetValue(currentValue);
    }

    public void defensa()
    {
        defensaActual = defensaActual + 1;
        ManagerScn.turnoEnemigo = true;
        ManagerScn.turnoPlayer = false;

    }

    public void enemiDefense()
    {
        
    }
}