using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Player : MonoBehaviour
{

    private Rigidbody2D myRigidbody;

    private int seconds;

    [SerializeField]
    private TextMeshProUGUI secondsText;

    [SerializeField]
    private TextMeshProUGUI totalSecondsText;

    [SerializeField]
    private GameObject ScoreScreen;

    // Start is called before the first frame update
    void Start()
    {
        seconds = 0;
        myRigidbody = GetComponent<Rigidbody2D>();
        InvokeRepeating("UpdateSeconds", 1f, 1f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            Damage();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), 0);
        myRigidbody.velocity = input * 10;
    }
    private void Damage()
    {
        int savedScore = PlayerPrefs.GetInt("MaxScore", 0);
        if (seconds > savedScore)
        {
            PlayerPrefs.SetInt("MaxScore", seconds);
        }
        ScoreScreen.SetActive(true);
        totalSecondsText.text = "Your score is: " + seconds + " Seconds";
        Destroy(gameObject);
    }
    private void UpdateSeconds() 
    {
        seconds = seconds + 1;
        secondsText.text = "Seconds: " + seconds;
    }
}
