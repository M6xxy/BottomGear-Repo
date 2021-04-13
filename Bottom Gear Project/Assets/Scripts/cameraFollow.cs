using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public Transform playerCamera;
    public Vector3 offset;
    void Update()
    {
        transform.position = new Vector3(playerCamera.position.x + offset.x, playerCamera.position.y + offset.y, offset.z);
    }
}
