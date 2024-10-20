using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoOnState : BaseStateInteractuable
{
    public override void EnterState(ObjetoInteractuable objetoCogido)
    {
        objetoCogido.miRenderer.material = objetoCogido.onMaterial;
        Debug.Log("Estoy en el estado On");
    }

    public override void UpdateState(ObjetoInteractuable objetoCogido)
    {
        if (true)
        {

        }

        else
        {
            objetoCogido.ChangeState(objetoCogido.OffState);
        }
    }

    public override void OnCollisionEnter(ObjetoInteractuable objetoCogido)
    {

    }
}
