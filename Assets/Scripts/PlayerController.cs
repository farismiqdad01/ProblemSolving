using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5;
    private float minX = -9, maxX = 9, minY = -5, maxY = 5;
    private Vector2 mosPos;
    public Text scoreText;
    private int score;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        mosPos = Input.mousePosition;
        mosPos = Camera.main.ScreenToWorldPoint(mosPos);
        scoreText.text = "Score : " + score.ToString();
    }
    void FixedUpdate()
    {
        

        if (mosPos.x > minX && mosPos.x < maxX && mosPos.y > minY && mosPos.y < maxY)
        {
            transform.position = Vector2.MoveTowards(transform.position, mosPos, speed * Time.deltaTime);
        }
        else
        {
            return;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "kotak")
        {
            score++;
        }
    }

}
