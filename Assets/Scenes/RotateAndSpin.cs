using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAndSpin : MonoBehaviour
{

    private Vector3 CurrentPosition;
    [SerializeField] private float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        CurrentPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = CurrentPosition + new Vector3((5 * Mathf.Cos(Time.time * speed)), 0, 5 * Mathf.Sin(Time.time * speed)) ;
        
        transform.Rotate(0f, 100f * Time.deltaTime, 0f); 
    }
}
