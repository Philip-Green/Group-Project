using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxLeft : MonoBehaviour
{
  private Transform myTransform;
  private float speed;
    // Start is called before the first frame update
    void Start()
    {
      myTransform = transform;
      speed = Random.Range(-1.50f, 1.50f);
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position += (Vector3.left * Time.deltaTime * speed) ;
    }
}
