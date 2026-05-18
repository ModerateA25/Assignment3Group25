using System.Collections.Generic;
using UnityEngine;

public class objectInteract : MonoBehaviour
{


    GameManager gameManager;

    public List<GameObject> children = new List<GameObject>();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.transform.tag == "Player")
        {
            gameManager.currentPickups += 1;
            foreach (GameObject i in children)
            {
                Destroy(i);
            }
            Destroy(this.gameObject);
        }
    }

}
