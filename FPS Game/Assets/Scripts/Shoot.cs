using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject myBullet;
    public float bulletSpeed = 100f;
    public Transform firePoint;

    public Rigidbody bullet;

    
    public int ammo = 30;
    public bool canFire = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Fire1") && canFire == true)

        if(Input.GetKeyDown(KeyCode.Mouse0) && canFire == true)
        {
            GameObject myBulletPrefabClone = Instantiate(myBullet, firePoint.transform.position, firePoint.rotation) as GameObject;
            Rigidbody myBulletPrefabRigidBody = myBulletPrefabClone.GetComponent<Rigidbody>();
            myBulletPrefabRigidBody.AddForce(Vector3.right * bulletSpeed, ForceMode.Impulse);
            print("pushed to shoot");

            
            // Before
            //Fire();
            
            ammo -= 1;


            if(ammo == 0 || ammo < 0)
            {
                canFire = false;

                
            }

            


        }


        if (ammo < 30)
        {
            if (Input.GetButton("Jump"))
            {
                ammo = 30;
                canFire = true;
            }
       // }
    //}
    /*
    void Fire()
    {
        Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, transform.position, transform.rotation);
        bulletClone.velocity = transform.right * bulletSpeed;
    }
    */
        }
    }
}
