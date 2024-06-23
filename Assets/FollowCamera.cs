using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    [SerializeField] GameObject carPlayerFollow;
    // this camera follow the car driver player position
    void LateUpdate()
    {
        transform.position = carPlayerFollow.transform.position + new Vector3(0, 0, -10);
    }
}
