using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    public float force = 100f;
    private Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    
        rigidbody.AddForce(transform.up * force, ForceMode.Impulse);

         Invoke("DestroyBullet", 5f);
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }


}