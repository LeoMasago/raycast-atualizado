using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        int qtd = Random.Range(1, 10);
        for (int i = 0; i < qtd; i++)
        {
            position.Set(10, 1, 10);
            Instantiate(prefab, position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
