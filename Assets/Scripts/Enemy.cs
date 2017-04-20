using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;

    private Transform target;
    private int waypointIndex = 0;

    // Use this for initialization
    void Start()
    {
        target = Waypoints.points[waypointIndex];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        // Check if the enemy reached the target waypoint
        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
    }

    private void GetNextWaypoint()
    {
        if (waypointIndex >= Waypoints.points.Count - 1)
        {
            Destroy(gameObject);
            return;
        }

        target = Waypoints.points[++waypointIndex];
    }
}
