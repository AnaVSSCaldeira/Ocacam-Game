using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BulletSpawnSystem : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bullet_spawn;
    public TextMeshProUGUI txt_ammo;
    
    public int ammo = 5;
    void Start()
    {
        txt_ammo.text=ammo.ToString();
    }
    
    void Update()
    {
        if(Time.timeScale != 0)
        {
            Spawn();
            if(ammo == 0 || (ammo < 5 && Input.GetKeyDown(KeyCode.R)))
            {
                // Invoke("NeedBullet", 2.0f);
                NeedBullet();
            }        
        }
    }

    void Spawn()
    {
        if (Input.GetMouseButtonDown(0) && ammo > 0)
        {
            Instantiate(bullet, new Vector3(bullet_spawn.transform.position.x, bullet_spawn.transform.position.y, bullet_spawn.transform.position.z), bullet_spawn.transform.rotation);
            ammo -= 1;
            txt_ammo.text=ammo.ToString();
        }
    }
    void NeedBullet()
    {
        // StartCoroutine(Reload());
        ammo = 5;
        txt_ammo.text=ammo.ToString();
    }

    // IEnumerator Reload()
    // {
    //     // for (int i = 0; i < 2; i++) 
    //     // {
    //         // sprite.color = new Color(1,1,1,0);
    //     yield return new WaitForSeconds(3f);
    //     ammo = 5;
    //     txt_ammo.text=ammo.ToString();
    //         // sprite.color = new Color(1,1,1,1);
    //         // yield return new WaitForSeconds(0.2f);
    //     // }
    // }
           
}
