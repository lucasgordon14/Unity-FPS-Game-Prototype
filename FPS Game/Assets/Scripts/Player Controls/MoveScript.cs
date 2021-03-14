using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    
    [SerializeField] private float speed = 1;
    [SerializeField] private float lookSpeed = 1.5f;
    [SerializeField] private float jumpForce = 5;
    [SerializeField] private float jumpRaycastDistance;
    public Rigidbody rb;
    
    
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        jump();

        if (Input.GetAxis("Mouse X") < 0)

            transform.Rotate(Vector3.up * -lookSpeed);

        if (Input.GetAxis("Mouse X") > 0)
            transform.Rotate(Vector3.up * lookSpeed);
    }
    private void FixedUpdate()
    {
        move();
    }
    private void jump()
    {
        Rigidbody rigBody = GetComponent<Rigidbody>();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if (IsGrounded())
            {
                rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
            }
        }
    }

    private void move()
    {
        float vAxis = Input.GetAxisRaw("Horizontal");
        float hAxis = -(Input.GetAxisRaw("Vertical"));
        Debug.Log("moving");
        Vector3 movement = new Vector3(hAxis, 0, vAxis) * speed ;

        Vector3 newPositon = rb.position + rb.transform.TransformDirection(movement);
        rb.MovePosition(newPositon);
    }
   
    private bool IsGrounded()
    {
        Debug.DrawRay(transform.position, Vector3.down * jumpRaycastDistance, Color.blue);
        
        return Physics.Raycast(transform.position, Vector3.down * jumpRaycastDistance);
    }
   //------------------------------------------------------------------
   /*
    public float moveSpeed = 5f;
    public float speed = 0.001f;

    public Transform firePoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Mouse X") < 0)
        
            transform.Rotate(Vector3.up * -speed);
        
        if (Input.GetAxis("Mouse X") > 0)
            transform.Rotate(Vector3.up * speed);

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.right * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.forward * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.left * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.back * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 10;

            
        }

        else {
            moveSpeed = 5;
        }
        
        //Debug.Log("Stuff");
    }
    */
}

