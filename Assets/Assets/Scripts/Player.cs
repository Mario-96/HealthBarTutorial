using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    private Stat Health;

    [SerializeField]
    private Stat energy;

    [SerializeField]
    private Stat Shield;

    private void Awake()
    {
        Health.Initialize();
        energy.Initialize();
        Shield.Initialize();
    }

    // Update is called once per frame
    void Update ()
    {
	    if (Input.GetKeyDown(KeyCode.Q))
        {
            Health.CurrentVal -= 10;
        }
            if (Input.GetKeyDown(KeyCode.W))
        {
            Health.CurrentVal += 10;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            energy.CurrentVal -= 10;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            energy.CurrentVal += 10;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Shield.CurrentVal -= 10;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Shield.CurrentVal += 10;
        }


    }
}
