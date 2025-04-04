using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform target;
    public bool isMoving = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null && isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * 5f);
        }

    }
    void OnCollisionEnter(Collision collision)
    {
        // Kiểm tra xem đối tượng va chạm có phải là target không
        if (collision.transform == target)
        {
            isMoving = false;
            Debug.Log("Stopppp");
        }
    }
}

