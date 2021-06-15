using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            gameManager.addLives(-1);
        }
        else
        {
            Destroy(other.gameObject);
            gameObject.GetComponent<AnimalHunger>().FeedAnimal(1);
        }
    }
}
