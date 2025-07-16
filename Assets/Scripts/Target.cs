using System;
using UnityEngine;

public class Target : MonoBehaviour
{
    public static event Action OnHit;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
            OnHit?.Invoke();
    }
}