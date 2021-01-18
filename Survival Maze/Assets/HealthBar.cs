using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;

    public void setHealth(int health)
    {
        slider.value = health;
    }
    public void setMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public float getcurrentHealth()
    {
        return slider.value;
    }
    public float getMaxHealth()
    {
        return slider.maxValue;
    }

    public void takeDamage(int health)
    {
        slider.value = slider.value - health;
        if (slider.value < 0) slider.value = 0;
    }

    public void heal(int health)
    {
        slider.value = slider.value + health;
        if (slider.value > slider.maxValue) slider.value = slider.maxValue;
    }
}
