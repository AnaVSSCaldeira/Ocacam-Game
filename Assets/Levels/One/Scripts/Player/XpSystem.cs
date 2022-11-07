using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XpSystem : MonoBehaviour
{
    public Image xp_content;
    public float xp;
    void Start()
    {
        xp = 0f;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GainXp()
    {
        // if(Input.GetKeyDown(KeyCode.Space))
        // {
        xp += 0.05f;
        xp_content.fillAmount = xp;
        // }
    }
}
