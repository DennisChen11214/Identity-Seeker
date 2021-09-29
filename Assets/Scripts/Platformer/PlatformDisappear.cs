using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlatformDisappear : MonoBehaviour
{
    public int startTime;
    public int interval;
    [SerializeField] Vector3 offset;
    Vector3 originalPos;

    void Start()
    {
        InvokeRepeating("Fade", startTime, interval);
        originalPos = transform.position;
    }

    void Fade(){
        // if(GetComponent<Tilemap>().color.a == 1){
        //     StartCoroutine("FadeOut");
        // }
        // else{
        //     StartCoroutine("FadeIn");
        // }
        if(transform.position != originalPos){
            StartCoroutine("MoveBack");
        }
        else{
            StartCoroutine("Move");
        }
    }

    IEnumerator FadeIn(){
        float aTime = 1.0f;
        GetComponent<TilemapCollider2D>().enabled = true;
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
        {
            Color newColor = new Color(1, 1, 1, Mathf.Lerp(0,1,t));
            GetComponent<Tilemap>().color = newColor;
            yield return null;
        }
        GetComponent<Tilemap>().color = new Color(1, 1, 1, 1);
    }

    IEnumerator FadeOut(){
        float aTime = 1.0f;
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
        {
            Color newColor = new Color(1, 1, 1, Mathf.Lerp(1,0,t));
            GetComponent<Tilemap>().color = newColor;
            yield return null;
        }
        GetComponent<TilemapCollider2D>().enabled = false;
        GetComponent<Tilemap>().color = new Color(1, 1, 1, 0);
    }

    IEnumerator Move(){
        float aTime = 1.0f;
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
        {
            transform.position = Vector3.Lerp(originalPos, originalPos + offset, t);
            yield return null;
        }
        transform.position = originalPos + offset;
    }

    IEnumerator MoveBack(){
        float aTime = 1.0f;
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
        {
            transform.position = Vector3.Lerp(originalPos + offset, originalPos, t);
            yield return null;
        }
        transform.position = originalPos;
    }
}
