using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MaxScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = "Pontuação Máxima: " + PlayerPrefs.GetInt("MaxScore", 0) + " Segundos";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
