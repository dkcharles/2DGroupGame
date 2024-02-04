using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _health = 5.0f; // player's health
    public float Health
    {
        get { return _health; }
        set { _health = value; }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
