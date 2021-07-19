using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScriptLinearIndicator : MonoBehaviour
{
    //This script is an example on how to use the linear indicator asset

    public LinearIndicator linearIndicator;
    

    public float minValue, maxValue;
    public float currentValue;

    void Start()
    {
        linearIndicator.SetupIndicator(minValue,maxValue);

        linearIndicator.SetValue(currentValue);


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(currentValue <= 0)
        {
            Debug.Log("Ganaste");
        }
        
    }

    public void ataque()
    {
        currentValue = currentValue - 30;
        linearIndicator.SetValue(currentValue);
    }
}
