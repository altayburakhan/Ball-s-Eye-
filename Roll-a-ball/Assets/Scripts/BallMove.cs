using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallMove : MonoBehaviour
{
    public Rigidbody naneci;

    public int level= 1;
    public int count;
    public int objectcount;
    public int velocity;
    public Text pointtext;
    public Text gameovertext;

    public Rigidbody Ball;
    void Start()
    {
        naneci = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");

        float dikey = Input.GetAxisRaw("Vertical");
        
        Vector3 vektor = new Vector3(yatay, 0, dikey);
        naneci.AddForce(vektor*velocity);
    }
    
    
    void OnTriggerEnter(Collider other) 
    {
        other.gameObject.SetActive(false);
        count++;
        pointtext.text = "Point : " + count;
        if(count == objectcount)
        {
            gameovertext.gameObject.SetActive(true);
        
        }
        
    }
    
}
