using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    private float _health = 60;

    public float GetHealth()
    {
        return _health;
    }

    public void Sethealth(float newHealth) 
    {
        _health = newHealth;
    }
}
