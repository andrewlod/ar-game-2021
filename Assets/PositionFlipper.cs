using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionFlipper : MonoBehaviour
{
    public Transform imageTopLeft;
    public Transform imageBotRight;
    public Transform cameraTopLeft;
    public Transform cameraBotRight;
    public Transform target;

    public float z = 6f;

    private Vector3 baseRotation;

    // Start is called before the first frame update
    void Start()
    {
        baseRotation = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(cameraTopLeft.position.x - (target.position.x + imageTopLeft.position.x) * 93.24f,
                                        cameraTopLeft.position.y + (target.position.y - imageTopLeft.position.z) * 62.5f, z);
        if (target.eulerAngles.y < 180)
        {
            transform.eulerAngles = new Vector3(baseRotation.x + -90 - target.eulerAngles.x, baseRotation.y, baseRotation.z);
        }
        else
        {
            transform.eulerAngles = new Vector3(baseRotation.x + 90 + target.eulerAngles.x, baseRotation.y, baseRotation.z);
        }
    }
}
