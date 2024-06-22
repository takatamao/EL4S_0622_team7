using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmickBase : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) OnTriggerEnterPlayer();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) OnCollisionEnterPlayer();
    }

    protected virtual void OnTriggerEnterPlayer() { }
    protected virtual void OnCollisionEnterPlayer() { }

}
