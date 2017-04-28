using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{

    private Transform target;

    public float speed = 40f;

    void Start()
    {

    }

    public void SetTarget(Transform _target)
    {
        target = _target;
    }

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        // How far the bullt travelled
        float distanceTravelled = speed * Time.deltaTime;

        if (dir.magnitude <= distanceTravelled)
        {
            HitTarget();
        }
    }

    void HitTarget()
    {
        Destroy(gameObject);
        Destroy(target.gameObject);
        return;
    }
}
