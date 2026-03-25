using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cutter : MonoBehaviour
{

    public Text t_score;
    public Text t_fruitsCut;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            GameManager.fruitsCut++;
            GameManager.score += other.GetComponent<ItemEffects>().points;
            t_score.text = GameManager.score.ToString();
            t_fruitsCut.text = GameManager.fruitsCut.ToString();
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
