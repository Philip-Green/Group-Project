using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasdMovement : MonoBehaviour
{
  public Transform myTransform;

  private float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
      myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.W))
      {
        myTransform.position += new Vector3 (0, 0, Time.deltaTime * speed );
      }
      if(Input.GetKeyUp(KeyCode.W))
      {
        myTransform.position += Vector3.forward;
      }
      if(Input.GetKey(KeyCode.S))
      {
        myTransform.position += new Vector3 (0, 0, -Time.deltaTime * speed );
      }
      if(Input.GetKeyDown(KeyCode.S))
      {
        myTransform.position += Vector3.back;
      }
    }
}
