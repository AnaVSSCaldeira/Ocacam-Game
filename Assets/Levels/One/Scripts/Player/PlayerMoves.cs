using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoves : MonoBehaviour
{
    public float vel = 6f;
    public Animator anim;
    public LifeSystem LS;

    void FixedUpdate()
    {
        if(LS.life > 0)
        {
            float H = Input.GetAxis("Horizontal");
            float V = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(H, V, 0f);

            anim.SetFloat("Horizontal", movement.x);
            anim.SetFloat("Vertical", movement.y);
            anim.SetFloat("Speed", movement.magnitude);

            transform.Translate(movement*vel*Time.deltaTime);
            
            // rigidbody2D.AddForce(Vector2(H * vel, V * vel));
            // if(H > 0)
            // {
            //     print("POSITIVO!");
            // }
            // if(H < 0)
            // {
            //     print("NEGATIVO!");
            // }
        }
    }
}

