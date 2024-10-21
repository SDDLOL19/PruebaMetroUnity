using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoOffState : BaseStateInteractuable
{
    public override void EnterState(ObjetoInteractuable objetoCogido)
    {
        Debug.Log("EstoyOff");
        objetoCogido.miRenderer.material = objetoCogido.offMaterial;

        objetoCogido.EncenderLuces(true);
    }

    public override void UpdateState(ObjetoInteractuable objetoCogido)
    {

    }

    public override void OnCollisionEnter(ObjetoInteractuable objetoCogido)
    {

    }
}
