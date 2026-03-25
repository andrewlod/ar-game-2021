using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEffects : MonoBehaviour
{

    private Camera cam;
    public GameObject splat;
    public int points = 10;

    void Start()
    {
        cam = GameObject.Find("Camera").GetComponent<Camera>();
    }

    void OnDestroy()
    {
        GameObject canvas = GameObject.Find("Canvas");
        GameObject obj = (GameObject) Instantiate(splat, transform.position, new Quaternion(0,0,0,0));
        obj.transform.SetParent(canvas.transform, true);
        Vector2 screenPoint = RectTransformUtility.WorldToScreenPoint(cam, transform.position);
        obj.GetComponent<RectTransform>().anchoredPosition = canvas.transform.InverseTransformPoint(screenPoint);

    }
}
