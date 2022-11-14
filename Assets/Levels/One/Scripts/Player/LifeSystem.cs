using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.SceneManagement;

public class LifeSystem : MonoBehaviour
{   
    public Image life_content;
    public float life = 10f;

    public SpriteRenderer sprite;

    public bool recovery;

    void Start()
    {
        life = life/10;
    }

    void Update()
    {

    }

    void DamageTaked(float damage)
    {
        if(life > 0)
            {
                if(recovery == false)
                {
                    life -= damage;
                    StartCoroutine(Flick());
                }
            }
        else
            {
                life = 0;
                Destroy(gameObject);
            }
            life_content.fillAmount = life; 
    }

    IEnumerator Flick()
    {
        recovery = true;
        for (int i = 0; i < 3; i++) 
        {
            sprite.color = new Color(1,1,1,0);
            yield return new WaitForSeconds(0.2f);
            sprite.color = new Color(1,1,1,1);
            yield return new WaitForSeconds(0.2f);
        }
        recovery = false;
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
