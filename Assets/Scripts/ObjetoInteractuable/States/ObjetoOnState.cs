using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoOnState : BaseStateInteractuable
{
    public override void EnterState(ObjetoInteractuable objetoCogido)
    {
        Debug.Log("EstoyOn");
        objetoCogido.ToDoWhenOn();
        objetoCogido.miRenderer.material = objetoCogido.onMaterial;
    }

    public override void UpdateState(ObjetoInteractuable objetoCogido)
    {

    }

    public override void OnCollisionEnter(ObjetoInteractuable objetoCogido)
    {

    }
}
