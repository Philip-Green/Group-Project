using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightWASDmovement : MonoBehaviour
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
      if(Input.GetKey(KeyCode.A))
      {
        myTransform.position += new Vector3 (-Time.deltaTime * speed, 0 , 0);
      }
      if(Input.GetKeyUp(KeyCode.A))
      {
        myTransform.position += Vector3.left;
      }
      if(Input.GetKey(KeyCode.D))
      {
        myTransform.position += new Vector3 (Time.deltaTime * speed, 0 , 0);
      }
      if(Input.GetKeyUp(KeyCode.D))
      {
        myTransform.position += Vector3.right;
      }
    }
}
