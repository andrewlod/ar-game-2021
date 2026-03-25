using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{

    public Transform start;
    public Transform end;
    public GameObject[] items;

    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        difference = end.position.x - start.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.frameCount % 100 == 0 && Time.time > 10f)
        {
            Instantiate(items[(int)Random.Range(0, items.Length)], new Vector3(start.position.x + Random.Range(0,difference), start.position.y, start.position.z), start.rotation);
        }
    }
}
