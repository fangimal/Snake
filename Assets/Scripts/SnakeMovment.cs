using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SnakeMovment : MonoBehaviour
{
    public float speed = 3;
    public float rotationSpeed = 90;

    public float z_offset = -0.5f;

    public GameObject[] tailObjects = new GameObject[1];

    public GameObject tailPrefab;
    void Start()
    {
        tailObjects[0] = gameObject;
    }

void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
        }
    }

    void AddTail()
    {
        tailObjects = new GameObject[tailObjects.Length + 1];
        Vector3 newTailPos = tailObjects[tailObjects.Length].transform.position;
        newTailPos.z -= z_offset;
        tailObjects[tailObjects.Length] = GameObject.Instantiate(tailPrefab, newTailPos, Quaternion.identity);
    }
}
