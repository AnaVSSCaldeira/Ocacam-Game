using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float veloc = 10f;
    public Animator anim;

    void FixedUpdate()
    {
        
        transform.Translate(new Vector2(veloc * Time.deltaTime,0));
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Wall") || other.CompareTag("Enemy")) 
        {
            // audio_source_damage.PlayOneShot(sound_effect_damage);
            veloc = 0;
            anim.SetBool("Alive",false);
            Destroy(gameObject, 0.2f);
        }
    }
}
