using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthChanger : MonoBehaviour
{
    public Player player;
    public Slider slider;
    public Button buttonTreatment;
    public Button buttonDamage;
    private float _minHealth = 0;
    private float _maxHealth = 100;
    private float _amountOfChangePerClick = 10;
    private float _timeForChange = 0.5f;

    public void Start()
    {
        slider.value = player.GetHealth();
    }

    public void Update()
    {
        if(slider.value != player.GetHealth())
        {
            slider.value = Mathf.MoveTowards(slider.value, player.GetHealth(), _timeForChange);
        }
    }

    private void ChangPlayerHealth(int directionOfChange) 
    {
        float currentHealth = player.GetHealth();
        float playerHealth = currentHealth + _amountOfChangePerClick * directionOfChange;  
        player.Sethealth(playerHealth);
        CompareValueWithLimit(buttonTreatment, _maxHealth);
        CompareValueWithLimit(buttonDamage, _minHealth);
    }

    private void CompareValueWithLimit(Button button, float limitValue) 
    {
        float playerHealth = player.GetHealth();

        if(playerHealth == limitValue)
        {
            button.interactable = false;
        }
        else
        {
            button.interactable = true;
        }
    }
}   


