using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMotion : MonoBehaviour
{

    private float speed = 1.5f;
    public Transform deletePos;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        speed = Random.Range(1f, 4f);
        transform.eulerAngles = new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0f, -speed * Time.deltaTime, 0f), Space.World);
        if (transform.position.y < deletePos.position.y)
        {
            gameManager.LoseLife();
            Destroy(gameObject);
        }
    }
}
