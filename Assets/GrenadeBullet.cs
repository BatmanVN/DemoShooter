using System;
using UnityEngine;

public class GrenadeBullet : MonoBehaviour
{
    public GameObject explosionPrefab;
    public float explosionRadius;
    public float explosionForce;
    public float dame;

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
        BlowObject();
    }

    private void BlowObject()
    {
        Collider[] affectedObjects = Physics.OverlapSphere(transform.position, explosionRadius);
        for (int i = 0; i < affectedObjects.Length; i++)
        {
            DeliverDame(affectedObjects[i]);
            AddForceToObjects(affectedObjects[i]);
        }
    }

    private void DeliverDame(Collider victim)
    {
        Health health = victim.GetComponent<Health>();
        Debug.Log($"HP: {victim}");
        if(health != null)
        {
            health.TakeDame(dame);
        }
    }
    private void AddForceToObjects(Collider affectedObjects)
    {
        var rigbody = affectedObjects.attachedRigidbody;
        if (rigbody)
        {
            rigbody.AddExplosionForce(explosionForce, transform.position, explosionRadius, 1, ForceMode.Impulse);
        }
    }
}