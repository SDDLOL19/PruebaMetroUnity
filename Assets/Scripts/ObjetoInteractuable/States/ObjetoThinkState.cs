using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoThinkState : BaseStateInteractuable
{
    public override void EnterState(ObjetoInteractuable objetoCogido)
    {
        Debug.Log("EstoyThink");
    }

    public override void UpdateState(ObjetoInteractuable objetoCogido)
    {
        if (objetoCogido.siendoVisto)
        {
            objetoCogido.ChangeState(objetoCogido.LookedState);
        }

        else
        {
            objetoCogido.ToDoWhenThink();
        }
    }

    public override void OnCollisionEnter(ObjetoInteractuable objetoCogido)
    {

    }
}
