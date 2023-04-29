using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class Squishy : MonoBehaviour, IDamagable
{
    public HealthBarController bar;
    public int health = 5;

    private void OnTriggerEnter(Collider other)
    {
        TakeDamage();
    }

    public void TakeDamage()
    {
        health -= 1;
        Debug.Log(health);
        bar.ShowDamage();
    }
}
