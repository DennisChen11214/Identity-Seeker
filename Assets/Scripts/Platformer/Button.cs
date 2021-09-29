using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Button : MonoBehaviour
{
    [SerializeField] GameObject target;
    bool done = false;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player" && !done){
            done = true;
            StartCoroutine("FadeOut");
        }
    }

    IEnumerator FadeOut(){
        float aTime = 1.0f;
        Vector3 oldPos = transform.position;
        Vector3 newPos = transform.position + Vector3.down * 0.4f;
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
        {
            Color newColor = new Color(1, 1, 1, Mathf.Lerp(1,0,t));
            target.GetComponent<Tilemap>().color = newColor;
            transform.position = Vector3.Lerp(oldPos, newPos, t);
            yield return null;
        }
        Destroy(target);
    }
}
