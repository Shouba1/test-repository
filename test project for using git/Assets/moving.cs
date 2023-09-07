using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    public int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");
        Vector2 direction = new Vector2(x, y) * speed * Time.deltaTime;
        gameObject.GetComponent<Rigidbody>().transform.Translate(direction);
    }
}