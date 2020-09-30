using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxMovement : MonoBehaviour
{
    public Transform myTransform;
    public float speed;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        myTransform.position = new Vector3 (-4,0,0);
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
      timer += Time.deltaTime;
      if (timer>=3){
        timer = 0;
        myTransform.position += new Vector3 (4,0,0);
      }
    }
}
