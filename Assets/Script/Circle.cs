using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Circle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField] private Vector3 direction;
    [SerializeField] private float speed = 5;

    // Update is called once per frame
    void Update()
    {

        Movement();
    }

    public void Movement()
    {
        transform.position += direction * Time.deltaTime * speed;
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }
}
