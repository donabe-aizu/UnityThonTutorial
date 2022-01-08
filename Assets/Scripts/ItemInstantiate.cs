using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInstantiate : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform points;
    public List<Transform> pointsList = new List<Transform>();
    void Awake()
    {
        for (int i = 0; i < points.childCount; i++)
        {
            pointsList.Add(points.GetChild(i));
        }
        foreach (Transform point in pointsList)
        {
            Instantiate(prefab, point.position, prefab.transform.rotation, this.transform);
        }
    }
    
    void Update()
    {
        
    }
}
