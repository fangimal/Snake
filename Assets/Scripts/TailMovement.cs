using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailMovement : MonoBehaviour
{
    public float speed = 3;
    public float rotationSpeed = 90;
    public GameObject tailTarget;
    public SnakeMovment mainSnake;
    void Start()
    {
        mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMovment>();
        tailTarget = mainSnake.tailObjects[mainSnake.tailObjects.Length-1];
    }


    void Update()
    {
        transform.LookAt(tailTarget.transform);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
