using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // camera should follow the car

    [SerializeField] GameObject thingToFollow;

    // using LateUpdate here to help ensure smooth camera movement
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0,0,-10);
    }
}
