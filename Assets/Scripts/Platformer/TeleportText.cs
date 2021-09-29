using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportText : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] GameObject cam;

    private void Update() {
        if(!target.activeSelf) return;
        float offsetPosY = target.transform.position.y + 1.5f;
        Vector3 offsetPos = new Vector3(target.transform.position.x, offsetPosY, transform.position.z);
        Vector2 screenPoint = cam.GetComponent<Camera>().WorldToScreenPoint(offsetPos);
        transform.position = screenPoint;
    }
}
