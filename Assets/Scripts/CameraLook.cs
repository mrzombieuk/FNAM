using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{

    [SerializeField] private float MinLookDistance;
    [SerializeField] private float MaxLookDistance;
    [SerializeField] private float CameraLookSensitivity;

    private float CameraLookDistance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CameraLookDistance = Mathf.Clamp(CameraLookDistance + Input.GetAxis("Mouse X") * CameraLookSensitivity, MinLookDistance, MaxLookDistance);
        gameObject.transform.localRotation = Quaternion.Euler(0f, CameraLookDistance, 0f);
    }
}
