using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour
{
    private Vector2 direction;
    private float angle;
    private bool face = true;

    // public Transform gun;
    public float speed = 10f;

    void Start()
    {

    }

    void Update()
    {
        if(Time.timeScale != 0)
        {
            GetMousePosition();
        }
    }

    void GetMousePosition()
    {
        // direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        // transform.up = direction;

        direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // // this.transform.eulerAngles = new Vector3(0, 0, angle);
        // // this.transform.eulerAngles = new Vector3(0, 0, zRotate); //entre 90 e -90 flipar o eixo Y

        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
        if((angle >= 90 && angle <= 180) || (angle <= -90 && angle >= -180))
        {
            if(face)
            {
                Flip();
            }
        }
        else
        {
            if(!face)
            {
                Flip();
            }
        }
    }

    void Flip()
    {
        face=!face;
        Vector3 newScale = transform.localScale;
        newScale.y *= -1;
        transform.localScale = newScale;
    }
}