using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    [SerializeField] string PlayerNum;
    private void Update() {
        GetComponent<Text>().text = "" + PlayerPrefs.GetInt(PlayerNum);
    }
}
