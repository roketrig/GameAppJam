using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private float horizontal;
    [SerializeField] private float speed;
    [SerializeField] private float wallL;
    [SerializeField] private float wallR;
    private float vercitalY;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vercitalY = Input.GetAxis("Vertical");
        horizontal *= speed * Time.deltaTime;
        transform.Translate(0, vercitalY * speed * Time.deltaTime, 0);

        float xPosition = transform.position.x + horizontal;
        float yPosition = transform.position.y + vercitalY;

        xPosition = Mathf.Clamp(xPosition, wallL, wallR);
        transform.position = new Vector3(xPosition,transform.position.y, transform.position.z);

    }
}
