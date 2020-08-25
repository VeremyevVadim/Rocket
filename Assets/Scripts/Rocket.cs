using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField]
    private int speedX = 3;

    [SerializeField]
    private float speedY = 3;
    public float SpeedY
    {
        get { return speedY / 10; }
        set { }
    }

    private Transform _transform;

    void Start()
    {
        _transform = GetComponent<Transform>();
        speedY = 3;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A)) 
        {
            _transform.Translate(-speedX * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _transform.Translate(speedX * Time.deltaTime, 0, 0);
        }
    }
}
