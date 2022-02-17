using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    float speed = 5.0f;

    public float jumpForce = 500.0f;

    public Text gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
        }

        if (this.gameObject.transform.position.y < -5.0f)
        {
            gameOverText.gameObject.SetActive(true);
        }

        if (this.gameObject.transform.position.y < -50.0f)
        {
            gameObject.transform.position = Vector3.zero;
            gameOverText.gameObject.SetActive(false);
        }
    }
}
