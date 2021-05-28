using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnakeMovment : MonoBehaviour
{
    public float speed = 3;
    public float rotationSpeed = 90;

    public float z_offset = -0.5f;

    public List<GameObject> tailObjects = new List<GameObject>();

    public GameObject tailPrefab;

    public Text scoreText;
    public int score = 0;
    void Start()
    {
        tailObjects.Add(gameObject);
    }

void Update()
    {
        scoreText.text = score.ToString();
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

    public void AddTail()
    {
        score++;
        Vector3 newTailPos = tailObjects[tailObjects.Count-1].transform.position;
        //newTailPos.z -= z_offset;
        tailObjects.Add(GameObject.Instantiate(tailPrefab, newTailPos, Quaternion.identity)); //as GameObject);
    }
}
