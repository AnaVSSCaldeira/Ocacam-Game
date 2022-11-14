using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bullet_spawn;
    public TextMeshProUGUI txt_ammo;
    public GameObject reload_feedback;
    
    public int ammo = 5;
    public bool can_shot = true;
    public bool reload = true; 

    void Start()
    {
        txt_ammo.text=ammo.ToString();
    }
    

    void Update()
    {
        if(ammo == 0)
        {
            can_shot = false;
        }
        if(can_shot == true && Input.GetMouseButtonDown(0))
        {
            Fire();
        }
        if((can_shot == false) || (ammo < 5 && Input.GetKeyDown(KeyCode.R)))
        {
            NeedBullet();
        }
    }

    void Fire()
    {
        if(ammo == 0)
        {
            can_shot = false;
            return;
        }
        ammo --;
        Instantiate(bullet, new Vector3(bullet_spawn.transform.position.x, bullet_spawn.transform.position.y, bullet_spawn.transform.position.z), bullet_spawn.transform.rotation);
        txt_ammo.text=ammo.ToString();
    }
    void NeedBullet()
    {
        if(reload == true)
        {
            StartCoroutine(Reload());
        }
    }

    IEnumerator Reload()
    {
        reload = false;
        reload_feedback.SetActive(true);
        yield return new WaitForSeconds(3f);
        ammo = 5;
        can_shot = true;
        txt_ammo.text=ammo.ToString();
        reload = true;
        reload_feedback.SetActive(false);
    }
           
}
