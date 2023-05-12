using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabscript : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        int qtd = Random.Range(1, 10);
        for (int i = 0; i < qtd; i++)
        {
            position.Set(1, 2.58f, 1);
            Instantiate(prefab, position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
