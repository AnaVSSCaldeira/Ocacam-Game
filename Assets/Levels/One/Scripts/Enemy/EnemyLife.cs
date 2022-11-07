using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;
// using TMPro;

public class EnemyLife : MonoBehaviour
{
    public int enemy_life = 3;
    public GameObject player;
    public GameObject heart;
    public LifeSystem life;
    System.Random rd = new System.Random();
    // public TextMeshProUGUI txt_enemy_quantity;
    // public int enemyCount = 0;

    void Start()
    {
        // if(player != null)
        // {
            // player = GameObject.FindGameObjectWithTag("Player");
            // life = player.GetComponent<LifeSystem>();
            // print("ALO?");
        // }
    }

    void Update()
    {

    }
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Bullet"))
        {
            enemy_life -= 1;
            if(enemy_life == 0)
            {
                int rand_num = rd.Next(1,10);
                if(rand_num>8){
                    Instantiate(heart, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), this.transform.rotation);
                }
                PointsSystem.instance.points_number += 5;
                Destroy(gameObject);
            }
        }
    }    
}
