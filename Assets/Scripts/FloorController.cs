using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorController : MonoBehaviour {

    public float speed;
    public bool flag = true;
    public Rigidbody rb;
    public Transform tr;
    public Object prefab;
    public GameController gc;

	// Use this for initialization
	void Start () {
        rb.WakeUp();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 newMov = new Vector3(tr.position.x - speed, 0, 0);
        tr.position = newMov;
	}
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Boundary" && flag)
        {
            var clone = Instantiate(prefab, new Vector3(tr.position.x + 1, 0, 0),Quaternion.identity);
            clone.name = "floor " + gc.getFloorCounter();
            gc.setFloorCounter(1);
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Boundary")
        {
            System.Console.WriteLine("Deleting obj: " + this.name);
            Destroy(this.gameObject);
        }
    }
}
