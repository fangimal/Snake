using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGeneration : MonoBehaviour
{
    public float XSize = 8.8f;
    public float ZSize = 8.8f;
    public GameObject foodPrefabs;
    public GameObject curFood;
    public Vector3 curPos;
    void Start()
    {
        RandomPosition();
        curFood = GameObject.Instantiate(foodPrefabs, curPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RandomPosition()
    {
        curPos = new Vector3(Random.Range(XSize*-1, XSize),0.25f, Random.Range(ZSize * -1, ZSize));
    }
}
