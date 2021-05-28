using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TailMovement : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public Vector3 tailTarget;
    public GameObject tailTargetObject;
    public SnakeMovment mainSnake;
    public int indx;
    void Start()
    {
        mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMovment>();
        speed = mainSnake.speed + 1f;
        tailTarget = mainSnake.tailObjects[mainSnake.tailObjects.Count - 2].transform.position;
        tailTarget.z -= mainSnake.z_offset;
        tailTargetObject = mainSnake.tailObjects[mainSnake.tailObjects.Count - 2];
        indx = mainSnake.tailObjects.IndexOf(gameObject);
    }


    void Update()
    {
        tailTarget = tailTargetObject.transform.position;
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime *speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            if(indx > 2)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
