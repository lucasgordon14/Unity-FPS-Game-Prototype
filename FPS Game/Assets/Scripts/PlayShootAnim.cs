using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayShootAnim : MonoBehaviour
{
    Animator anim;
    public ParticleSystem muzzleflash;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("R2"))
        {
            //Animation Stuff
            anim.SetTrigger("Active");
            //var gunsound : AudioSource = GetComponent.< AudioSource > ();
            //gunsound.Play();
            GetComponent<Animation>().Play("Recoil");
            muzzleflash.Play();
            //Raycast Stuff
            RaycastHit whatIHit;
            if (Physics.Raycast(transform.position, transform.forward, out whatIHit, Mathf.Infinity))
            {
                Debug.Log(whatIHit.collider.name);
            }
        }
    }
}
