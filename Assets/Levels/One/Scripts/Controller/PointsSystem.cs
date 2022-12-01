using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsSystem : MonoBehaviour
{
    public TextMeshProUGUI txt_points;
    public int points_number = 0;
    public static PointsSystem instance;

    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        txt_points.text = points_number.ToString();
    }
}
