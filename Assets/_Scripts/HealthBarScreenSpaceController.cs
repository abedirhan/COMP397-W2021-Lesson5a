using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class HealthBarScreenSpaceController : MonoBehaviour
{
    [Header("Health Properties")] 
    
    [Range(0, 100)] public int currentHealt = 100;

    [Range(0, 100)] public int maximumHealth = 100;

    private Slider healthBarSlider;

    // Start is called before the first frame update
    void Start()
    {
        healthBarSlider = GetComponent<Slider>();

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void TakeDemage(int demage)
    {
        healthBarSlider.value -= demage;
        currentHealt -= demage;
        if (currentHealt < 0)
        {
            healthBarSlider.value = 0;
            currentHealt = 0;
           
        }
    }

    public void Reset()
    {
        healthBarSlider.value = maximumHealth;
        currentHealt = maximumHealth;
    }
}
