using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGeneratePre : MonoBehaviour
{
    public GameObject prefab;

    private void Awake()
    {
        Instantiate(prefab, this.transform.position, prefab.transform.rotation);
    }
}
