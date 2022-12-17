using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerMove : MonoBehaviour
{
    public float speed;
    public int points = 0;
    public TMP_Text pointsText;
   

 

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right * speed * Time.deltaTime * horizontalInput);

        if (transform.position.x < -7)
        {
            transform.position = new Vector2(-7, -3.5f);
        }
        if (transform.position.x > 7)
        {
            transform.position = new Vector2(7, -3.5f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Trash")
        {
            Destroy(collision.gameObject);
            points++;
            pointsText.text = "Points: " + points;
            if (points == 6)
            {
                UIManager.instance.RestarScene();

            }

        }
        else if (collision.tag == "GreenElements")
        {
            Destroy(collision.gameObject);
            points--;
            pointsText.text = "Points: " + points;
        }
    }
}
