using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // This camera's position should be the same as the car's postiton

    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0,0,-10);
    }
}
