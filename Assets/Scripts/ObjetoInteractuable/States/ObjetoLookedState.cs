using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoLookedState : BaseStateInteractuable
{
    public override void EnterState(ObjetoInteractuable objetoCogido)
    {
        Debug.Log("EstoySiendoVisto");
        objetoCogido.miRenderer.material = objetoCogido.lookedAtMaterial;

        objetoCogido.MissByRay();
        objetoCogido.ToDoWhenLookeed();
    }

    public override void UpdateState(ObjetoInteractuable objetoCogido)
    {
        if (Input.GetKey(KeyCode.E))
        {
            objetoCogido.ChangeState(objetoCogido.OnState);
        }

        else
        {
            objetoCogido.ChangeState(objetoCogido.ThinkState);
        }
    }

    public override void OnCollisionEnter(ObjetoInteractuable objetoCogido)
    {

    }
}
