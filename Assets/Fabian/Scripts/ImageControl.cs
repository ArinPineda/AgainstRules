using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageControl : MonoBehaviour
{
    [SerializeField] float speed = 500;
    [SerializeField] float speedLimit = 1500;
    public int slot;
    public string objectName;
    bool impulse = false;
    void Start()
    {
        objectName = gameObject.name;
       
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            impulse = true;
        }
        else
        {
            impulse = false;
        }
        // if (transform.position.y <= 100 && transform.position.y >= -50)
        // {
        //     Debug.Log(transform.position.x);
        // }
        transform.position += Vector3.down * speed * Time.deltaTime;
        if (transform.position.y < -300)
        {
            transform.position = new Vector3(transform.position.x, 402, 0);
        }
    }
    void FixedUpdate()
    {
        if (impulse && speed <= speedLimit)
        {
            speed += 10;
        }
        else
        {
            speed -= 2f;
        }

        if (speed <= 0)
        {
            speed = 0;
            UIManager.instance.ActivePanelFood();
            UIManager.instance.panelRoulete.SetActive(false);

        }
    }





}
