using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float verticalInput;
    private float speed = 20.0f;
    private int xRange = 20;
    private int zTop = 20;
    private int zBottom = -5;

    public static int score = 0;
    public static int lives = 3;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player score is " + score + ".");
        Debug.Log("Player has " + lives + " lives left.");
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Keep player in bounds, otherwise move freely within horizontal range.
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        else
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        }

        // Keep player in bounds, otherwise move freely within vertical range.
        if (transform.position.z < zBottom)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBottom);
        }
        else if (transform.position.z > zTop)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zTop);
        }
        else
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // should fire banana
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        if (lives <= 0)
        {
            Debug.Log("Game Over!");
        }
    }
}
