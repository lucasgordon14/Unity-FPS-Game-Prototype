using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCameraController : MonoBehaviour
{
    [SerializeField] private float lookSensitivity;
    [SerializeField] private float smoothing;

    private GameObject player;
    private Vector2 smoothedVelocity;
    private Vector2 currentLookingPosition;

    // Start is called before the first frame update
    void Start()
    {
        player = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        RotateCamera();
    }

    private void RotateCamera()
    {
        float vAxis = Input.GetAxisRaw("Horizontal");
        float hAxis = -(Input.GetAxisRaw("Vertical"));

        if (Input.GetJoystickNames().Length > 0)
        {
            Vector2 inputValues = new Vector2(vAxis, hAxis);
            inputValues = Vector2.Scale(inputValues, new Vector2(lookSensitivity * smoothing, lookSensitivity * smoothing));
            smoothedVelocity.x = Mathf.Lerp(smoothedVelocity.x, inputValues.x, 1f / smoothing);
            smoothedVelocity.y = Mathf.Lerp(smoothedVelocity.y, inputValues.y, 1f / smoothing);

            currentLookingPosition += smoothedVelocity;

            transform.localRotation = Quaternion.AngleAxis(-currentLookingPosition.y, Vector3.right);
            player.transform.localRotation = Quaternion.AngleAxis(currentLookingPosition.x, player.transform.up);
        }

        if (Input.GetJoystickNames().Length == 0)
        {
            Vector2 inputValues = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
            inputValues = Vector2.Scale(inputValues, new Vector2(lookSensitivity * smoothing, lookSensitivity * smoothing));
            smoothedVelocity.x = Mathf.Lerp(smoothedVelocity.x, inputValues.x, 1f / smoothing);
            smoothedVelocity.y = Mathf.Lerp(smoothedVelocity.y, inputValues.y, 1f / smoothing);

            currentLookingPosition += smoothedVelocity;

            transform.localRotation = Quaternion.AngleAxis(-currentLookingPosition.y, Vector3.right);
            player.transform.localRotation = Quaternion.AngleAxis(currentLookingPosition.x, player.transform.up);
        }
    }
}
