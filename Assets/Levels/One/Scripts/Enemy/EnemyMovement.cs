using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    public float speed = 4f;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if(player != null)
        {
            Vector3 scale = transform.localScale;
            if(player.transform.position.x > transform.position.x)
            {
                scale.x = Mathf.Abs(scale.x) * 1;
            }
            else
            {
                scale.x = Mathf.Abs(scale.x) * -1;
            }
            transform.localScale = scale;
        }
    }

    void FixedUpdate() 
    {
        if(player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }

}
