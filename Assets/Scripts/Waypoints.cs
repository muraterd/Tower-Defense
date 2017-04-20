using UnityEngine;
using System.Collections.Generic;

public class Waypoints : MonoBehaviour
{
    public static List<Transform> points = new List<Transform>();

    // Use this for initialization
    void Awake()
    {
        foreach (Transform child in transform)
        {
            points.Add(child);
        }
    }
}
