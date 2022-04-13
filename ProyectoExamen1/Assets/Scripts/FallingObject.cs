using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    [SerializeField] float spin = 1.0f;
    [SerializeField] float fallingSpeed = 1.0f;
    GameObject child;
    private void Start()
    {
        child = this.transform.GetChild(0).gameObject;
    }
    // Update is called once per frame
    void Update()
    {
        child.transform.Rotate(0, 0, spin * Time.deltaTime);
        transform.position += Vector3.down*fallingSpeed*Time.deltaTime;
    }
}
