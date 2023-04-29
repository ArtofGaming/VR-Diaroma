using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    public Slider healthBar;
    public Squishy ghost;
    // Start is called before the first frame update
    void Start()
    {
        healthBar.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowDamage()
    {
        healthBar.value = ghost.health/5f;
        Debug.Log("Changed");
    }
}
