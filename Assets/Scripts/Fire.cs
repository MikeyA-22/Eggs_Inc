using UnityEngine;
using System.Collections.Generic;

public class Fire : MonoBehaviour
{
    public GameObject bulletPrefab; 
    public float bulletSpeed = 20f; 
    public float fireRate = 1f; 
    public float detectionRadius = 50f;

    private List<GameObject> targets = new List<GameObject>();
    private float nextFireTime = 0f;

    void Start()
    {
        
        GameObject[] targetArray = GameObject.FindGameObjectsWithTag("Target");
        targets.AddRange(targetArray);
    }

    void Update()
    {
        
        
            GameObject nearestTarget = FindNearestTarget();
            if (nearestTarget != null)
            {
                ShootAtTarget(nearestTarget);
                nextFireTime = Time.time + fireRate;
            }
        
    }

    GameObject FindNearestTarget()
    {
        GameObject nearestTarget = null;
        float shortestDistance = Mathf.Infinity;

        foreach (GameObject target in targets)
        {
            float distance = Vector3.Distance(transform.position, target.transform.position);
            if (distance < shortestDistance && distance <= detectionRadius)
            {
                shortestDistance = distance;
                nearestTarget = target;
            }
        }

        return nearestTarget;
    }

    void ShootAtTarget(GameObject target)
    {
        
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

        
        Vector3 direction = (target.transform.position - transform.position).normalized;

        
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = direction * bulletSpeed;
        }
    }
}
