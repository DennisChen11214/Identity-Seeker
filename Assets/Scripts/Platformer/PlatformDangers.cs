using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDangers : MonoBehaviour
{
    [SerializeField] Transform spawnPos;

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            other.gameObject.transform.position = spawnPos.position;
        }
    }
}
