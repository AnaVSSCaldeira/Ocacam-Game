using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.SceneManagement;

public class LifeSystem : MonoBehaviour
{   
    public Image life_content;
    public float life = 10f;

    void Start()
    {
        life = life/10;
    }

    void Update()
    {
        // if(life > 0)
        // {
        //     PlayerLifeControl();
        // }
    }

    void DamageTaked(float damage)
    {
        if(life > 0)
            {
                life -= damage;
            }
            else
            {
                Destroy(gameObject);
                // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            life_content.fillAmount = life; 
    }

    void OnTriggerEnter2D(Collider2D another_object) 
    {
        if(another_object.gameObject.CompareTag("Heart") && life < 1)
        {
            life += 0.25f;
            if(life >= 1)
            {
                life = 1;
            }
            life_content.fillAmount = life;
            Destroy(another_object.gameObject);
        }
        else
        {
            float damage;
            if(another_object.gameObject.CompareTag("Enemy"))
            {
                damage = 0.25f;
                DamageTaked(damage);
            }
            else if(another_object.gameObject.CompareTag("Spike"))
            {
                damage = 0.50f;
                DamageTaked(damage);
            }
            
        }
    }
}
