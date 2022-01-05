using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInstantiate : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform points;
    private List<Transform> _pointsList;
    void Start()
    {
        for (int i = 0; i < points.childCount; i++)
        {
            _pointsList.Add(points.GetChild(i));
        }
        foreach (Transform point in _pointsList)
        {
            Instantiate(prefab, point.position, prefab.transform.rotation);
        }
    }
    
    void Update()
    {
        
    }
}
