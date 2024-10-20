using UnityEngine;

public abstract class BaseStateInteractuable
{
    public abstract void EnterState(ObjetoInteractuable objetoCogido);

    public abstract void UpdateState(ObjetoInteractuable objetoCogido);

    public abstract void OnCollisionEnter(ObjetoInteractuable objetoCogido);
}
