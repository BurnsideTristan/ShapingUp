using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

	public GameObject particle;

    public float speed;
    public float jumpHeight = 250;
    private Rigidbody rb;

    public int count;
    public Text countText;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpHeight);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
            Instantiate(particle, other.gameObject.transform.position, Quaternion.Euler(-90,0,0));
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }

}
