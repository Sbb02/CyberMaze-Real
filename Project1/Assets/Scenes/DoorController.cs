using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DoorController : MonoBehaviour
{
    public GameObject book, door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        // Rotate the door
        //door.Rotate(90f, 90f, 0f);
        door.SetActive(false);
        book.SetActive(false);
    }

    /*
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Check if the book has been clicked
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == book)
            {
                // Rotate the door
                transform.Rotate(90f, 90f, 0f);
            }
        }
    }
    */
}
