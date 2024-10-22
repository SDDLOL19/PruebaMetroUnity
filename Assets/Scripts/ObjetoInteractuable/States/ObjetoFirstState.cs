using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoFirstState : BaseStateInteractuable
{
    float timeToChange = 5, cronometro = 0;

    public override void EnterState(ObjetoInteractuable objetoCogido)
    {
        Debug.Log("Estoy en el estado Primero");
    }

    public override void UpdateState(ObjetoInteractuable objetoCogido)
    {
        cronometro += Time.deltaTime;

        if (cronometro >= timeToChange)
        {
            objetoCogido.ChangeState(objetoCogido.OffState);
        }
    }

    public override void OnCollisionEnter(ObjetoInteractuable objetoCogido)
    {

    }
}
