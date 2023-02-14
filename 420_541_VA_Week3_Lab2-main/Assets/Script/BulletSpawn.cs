using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform spawnPoint;
    public float maxForce = 1000f;
    public float minForce = 100f;

    private float currentForce;
    private float chargeTime;
    private bool isCharging;

    // Update is called once per frame
    void Update()
    {
      

        if (Input.GetButtonUp("Fire1"))
        {
            GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.AddForce(spawnPoint.forward * currentForce, ForceMode.Impulse);
        }

             if (Input.GetButtonDown("Fire1")){
           
        }
    }
}
    


