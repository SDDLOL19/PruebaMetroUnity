using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoOffState : BaseStateInteractuable
{
    public override void EnterState(ObjetoInteractuable objetoCogido)
    {
        Debug.Log("EstoyOff");
        objetoCogido.miRenderer.material = objetoCogido.offMaterial;
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
