using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField]
    private float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime, Space.World);
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime, Space.World);
    }
}
