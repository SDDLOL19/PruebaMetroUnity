using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoInteractuable : MonoBehaviour
{
    BaseStateInteractuable currentState;
    public ObjetoFirstState firstkState = new ObjetoFirstState();
    public ObjetoOnState OnState = new ObjetoOnState();
    public ObjetoOffState OffState = new ObjetoOffState();

    public MeshRenderer miRenderer;
    public Material onMaterial, offMaterial, lookedAtMaterial, baseMaterial;
    public Material previousMaterial;

    public GameObject[] luzPrincipal;

    void Start()
    {
        miRenderer = GetComponent<MeshRenderer>();

        currentState = firstkState; //Hace que el proximo estado sea el primer estado necesario

        currentState.EnterState(this); //Activa el metodo EnterState para que cambie a ese estado
    }

    void Update()
    {
        currentState.UpdateState(this);
    }

    private void OnCollisionEnter(Collision collision)
    {
        currentState.OnCollisionEnter(this); //si queremos también añadir la collision habría que cambiarlo aquí por (this, collision), y en la función (EnemyStateController enemy, Collision collision)
    }

    public void ChangeState(BaseStateInteractuable state)
    {
        currentState = state;
        state.EnterState(this);
    }

    public void EncenderLuces(bool encender)
    {
        luzPrincipal[0].SetActive(encender);
        luzPrincipal[1].SetActive(encender);
        //    if (encender)
        //    {
        //        luzPrincipal.transform.rotation = Quaternion.Euler(90, 0, 0);
        //    }

        //    else
        //    {
        //        luzPrincipal.transform.rotation = Quaternion.Euler(-90, 0, 0);
        //    }
    }
}
