using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerAction : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidBody;

    [SerializeField]
    private Text textPoints;

    public static int points = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           rigidBody.AddForce(Vector2.up * 6, mode: ForceMode2D.Impulse);
        }

        if(transform.position.y > 4.35f || transform.position.y < -4.58f)
        {
            SceneManager.LoadScene("EndGame");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("EndGame");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        points++;
        textPoints.text = "POINTS: " + points;
    }
}
