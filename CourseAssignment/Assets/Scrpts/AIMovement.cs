using UnityEngine;
using System.Collections;
 
public class AIMovement : MonoBehaviour {
    public GameObject Ball;
    private Transform CurrentTransform;
    public GameManager gameManager;
    private float speed = 3.5f;
    // Use this for initialization
    void Start () {
        CurrentTransform = this.transform;
    }
 
    // Update is called once per frame
    void Update () {
        if(!gameManager.win && !gameManager.loose)
        {
            CurrentTransform = this.transform;
            if (CurrentTransform.position.x < Ball.transform.position.x) {
                GetComponent<Rigidbody>().velocity = new Vector3 (1f, 0, 0)*speed;
            } else if (CurrentTransform.position.z > Ball.transform.position.z) {
                GetComponent<Rigidbody>().velocity = new Vector3 (-1f, 0, 0)*speed;
            } else {
                GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 0)*speed;
            }
        }
    }
}