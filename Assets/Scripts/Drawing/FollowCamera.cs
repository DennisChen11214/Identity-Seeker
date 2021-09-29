using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.InputSystem;

public class FollowCamera : MonoBehaviour
{
    void Update()
    {
        Vector3 temp = Input.mousePosition;
        temp.z = 10f;
        this.transform.position = Camera.main.ScreenToWorldPoint(temp);
    }
}
