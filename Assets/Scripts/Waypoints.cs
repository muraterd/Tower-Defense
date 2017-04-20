using UnityEngine;
using System.Collections.Generic;

public class Waypoints : MonoBehaviour
{
    public static List<Transform> points = new List<Transform>();

    // Use this for initialization
    void Start()
    {
        foreach (Transform child in transform)
        {
            points.Add(child);
        } 
    }

    // Update is called once per frame
    void Update()
    {

    }
}
