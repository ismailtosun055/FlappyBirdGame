using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slideer;

    public void SeMaxHealth(int health)
    {
        slideer.maxValue = health;
        slideer.value = health;
    }

    public void SetHealth(int health)
    {
        slideer.value = health;
    }

}
