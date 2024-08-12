using UnityEngine;

public class GunRayCaster : MonoBehaviour
{
    [SerializeField] private GameObject hitMarkerPrefab;
    [SerializeField] private Camera aimingCamera;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private float takeDame;
    public void PerformRayCasting()
    {
        Ray aimingRay = new Ray(aimingCamera.transform.position, aimingCamera.transform.forward);
        if (Physics.Raycast(aimingRay, out RaycastHit hitInfo, 1000f, layerMask))
        {
            ShowHitEffect(hitInfo);
            DeliverDamage(hitInfo);
            Debug.Log("chay chua");
        }
    }
    private void DeliverDamage(RaycastHit hitInfo)
    {
        Health health = hitInfo.collider.GetComponentInParent<Health>();
        Debug.Log(hitInfo);
        if (health != null)
        {
            health.TakeDame(takeDame);
            Debug.Log($"HP cua: {health.gameObject.name}");
            Debug.Log(takeDame);
        }
    }
    private void ShowHitEffect(RaycastHit hitInfo)
    {
        HitSurface hitSurface = hitInfo.collider.GetComponent<HitSurface>();
        if (hitSurface != null)
        {
            GameObject effectPrefab = HitEffectManager.Instance.GetEffectPrefab(hitSurface.surfaceType);
            if (effectPrefab != null)
            {
                Quaternion effectRotation = Quaternion.LookRotation(hitInfo.normal);
                Instantiate(effectPrefab, hitInfo.point, effectRotation);

            }
        }
    }
}