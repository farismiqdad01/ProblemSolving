using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KotakEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 poss = GameObject.Find("circle").transform.position;
        transform.position = Vector2.MoveTowards(transform.position, poss, 3 * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
