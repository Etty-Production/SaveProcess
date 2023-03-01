using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootInPerson : MonoBehaviour
{
    private Ray _ray;
    private RaycastHit _hit;
    [Header("Player, wich enemy look at/")]
    [SerializeField] private GameObject Camera;
    public bool Shoot;
    public float DamageEnemy = 20;

    private void UpdateRay()
    {
        _ray = new Ray(gameObject.transform.position, gameObject.transform.forward);
    }

    private void DrawRay()
    {
        Debug.DrawRay(_ray.origin, _ray.direction * 100f, Color.yellow);
        if (Physics.Raycast(_ray, out _hit))
        {
            Debug.DrawRay(_ray.origin, _ray.direction * 100f, Color.red);
        }
    }

    private void Update()
    {
        if (Shoot)
        {
            transform.LookAt(Camera.transform, Vector3.up);
            transform.rotation = new Quaternion(transform.rotation.x + Random.Range(0.0f, 0.02f) * Random.Range(-1, 2),
                transform.rotation.y + Random.Range(0.0f, 0.02f) * Random.Range(-1, 2), transform.rotation.z + Random.Range(0.0f, 0.02f) * Random.Range(-1, 2),
                    transform.rotation.w + Random.Range(0.0f, 0.02f) * Random.Range(-1, 2));
            UpdateRay();
            DrawRay();
            if (Physics.Raycast(_ray, out _hit))
            {
                GameObject obj = _hit.collider.gameObject;
                if (obj = Camera)
                {
                    // damage for player here
                    obj.GetComponent<DamageForPerson>().Damage(DamageEnemy);
                }
            }
            Shoot = false;
        }
    }
}
