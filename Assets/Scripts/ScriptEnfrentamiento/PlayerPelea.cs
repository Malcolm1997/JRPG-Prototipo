using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPelea : MonoBehaviour
{
    //This script is an example on how to use the linear indicator asset

    public LinearIndicator linearIndicatorPlayer;
    public LinearIndicator linearIndicatorEnemigo;


    public float minValuePlayer, maxValuePlayer, minValueEnemigo, maxValueEnemigo;
    public float currentValuePlayer, currentValueEnemigo;
    float defensaPlayer = 0;
    float defensaEnemiga = 0;
    public GameObject canvas, canvasFinal;
    public Text final;
    bool turno = true;


    void Start()
    {
        linearIndicatorPlayer.SetupIndicator(minValuePlayer, maxValuePlayer);

        linearIndicatorPlayer.SetValue(currentValuePlayer);

        linearIndicatorEnemigo.SetupIndicator(minValueEnemigo, maxValueEnemigo);

        linearIndicatorEnemigo.SetValue(currentValueEnemigo);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (currentValueEnemigo <= 0)
        {
            canvasFinal.SetActive(true);
            canvas.SetActive(false);
            final.text = "Ganaste";
        }
        if (currentValuePlayer <= 0)
        {
            canvasFinal.SetActive(true);
            canvas.SetActive(false);
            final.text = "Perdiste";
        }

        float valorRandom = Random.Range(0, 10);

        if(turno == false && currentValueEnemigo > 0)
        {
            if (valorRandom > 5)
            {
                ataqueNPC();
                turno = true;
            }
            else if (valorRandom > 2)
            {
                defensaNPC();
                turno = true;
            }
        }

    }

    public void ataquePJ()
    {
        if(defensaEnemiga == 0)
        {
            currentValueEnemigo = currentValueEnemigo - 30;
        } else

        {
            currentValueEnemigo = currentValueEnemigo - (30 - (defensaEnemiga * 2f));
        }
        linearIndicatorEnemigo.SetValue(currentValueEnemigo);

        turno = false;
    }

    public void defensaPJ()
    {
        defensaPlayer += 1;
        turno = false;
    }

    public void pasarTurno()
    {
        turno = false;
    }

    public void huirPJ()
    {
        if (Random.Range(0, 3) >= 2)
        {
            canvas.SetActive(false);
        }
        turno = false;
    }  

    public void ataqueNPC()
    {
        if (defensaPlayer == 0)
        {
            currentValuePlayer = currentValuePlayer - 20;
        }
        else
        {
            currentValuePlayer = currentValuePlayer - (20 - (defensaPlayer * 2f));
        }
        linearIndicatorPlayer.SetValue(currentValuePlayer);
    }

    public void defensaNPC()
    {
        defensaEnemiga += 1;
    }
}