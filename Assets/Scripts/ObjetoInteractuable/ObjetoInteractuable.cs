using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObjetoInteractuable : MonoBehaviour
{
    BaseStateInteractuable currentState;
    public ObjetoFirstState firstkState = new ObjetoFirstState();
    public ObjetoThinkState ThinkState = new ObjetoThinkState();
    public ObjetoLookedState LookedState = new ObjetoLookedState();
    public ObjetoOnState OnState = new ObjetoOnState();
    public ObjetoOffState OffState = new ObjetoOffState();

    public MeshRenderer miRenderer;
    public Material onMaterial, offMaterial, lookedAtMaterial, baseMaterial;
    public Material previousMaterial;

    public GameObject[] luzPrincipal, puertasParaAbrir;
    public GameObject puertaParaCerrar, miPlayer, motorFalso, textoPulsar;

    public bool siendoVisto = false;

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
        //currentState.OnCollisionEnter(this); //si queremos también añadir la collision habría que cambiarlo aquí por (this, collision), y en la función (EnemyStateController enemy, Collision collision)
    }

    public void ChangeState(BaseStateInteractuable state)
    {
        currentState = state;
        state.EnterState(this);
    }

    public void HitByRay()
    {
        //Debug.Log("I was hit by a Ray");
        siendoVisto = true;
    }

    public void MissByRay()
    {
        //Debug.Log("Lost");
        siendoVisto = false;
    }

    public void ToDoWhenOn()
    {
        textoPulsar.SetActive(false);
        miPlayer.transform.position = motorFalso.transform.position - (transform.position - miPlayer.transform.position);
        puertaParaCerrar.SetActive(true);
        puertasParaAbrir[0].SetActive(false);
        puertasParaAbrir[1].SetActive(false);
        EncenderLuces(true);
    }

    public void ToDoWhenLookeed()
    {
        textoPulsar.SetActive(true);
    }

    public void ToDoWhenThink()
    {
        textoPulsar.SetActive(false);
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
