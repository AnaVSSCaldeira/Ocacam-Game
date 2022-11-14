using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float veloc = 10f;
    public Animator anim;

    void FixedUpdate()
    {
        // anim.SetBool("Alive",true);
        transform.Translate(new Vector2(veloc * Time.deltaTime,0));
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Wall") || other.CompareTag("Enemy")) 
        {
            veloc = 0;
            anim.SetBool("Alive",false);
            // anim.alive = false;
            // anim.Play("Explosion");
            Destroy(gameObject, 0.2f);
        }
    }
}
