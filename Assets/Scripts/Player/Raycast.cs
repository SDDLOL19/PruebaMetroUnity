using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit) && Vector3.Distance(transform.position, hit.transform.position) <= 1.5)
        {
            if (hit.collider.TryGetComponent(out ObjetoInteractuable interactuable))
            {
                interactuable.HitByRay();
            }
        }

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1.5f, Color.white);
    }
}
