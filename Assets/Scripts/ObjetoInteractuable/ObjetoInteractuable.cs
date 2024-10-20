using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoInteractuable : MonoBehaviour
{
    BaseStateInteractuable currentState;
    public ObjetoThinkState ThinkState = new ObjetoThinkState();
    public ObjetoOnState OnState = new ObjetoOnState();
    public ObjetoOffState OffState = new ObjetoOffState();

    public MeshRenderer miRenderer;
    public Material onMaterial, offMaterial, lookedAtMaterial, baseMaterial;

    void Start()
    {
        miRenderer = GetComponent<MeshRenderer>();

        currentState = ThinkState; //Hace que el proximo estado sea el primer estado necesario

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
}
