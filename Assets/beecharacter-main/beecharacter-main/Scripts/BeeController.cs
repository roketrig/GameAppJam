using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class BeeController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 180f;

    private Rigidbody rb;
    private PlayerInput input;
    private Vector3 moveDirection;
    private Vector2 rotationDirection;
    private InputAction moveAction;
    private InputAction rotateAction;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        input = GetComponent<PlayerInput>();

        var inputActions = input.currentActionMap;
        moveAction = inputActions.FindAction("Move");
        rotateAction = inputActions.FindAction("Rotation");
        moveAction.Enable();
        rotateAction.Enable();

    }

    private void Update()
    {

        Vector3 moveInput = moveAction.ReadValue<Vector3>();
        Vector2 rotateInput = rotateAction.ReadValue<Vector2>();


        moveDirection = new Vector3(moveInput.x, moveInput.z, moveInput.y).normalized;
        transform.Translate(new Vector3(moveInput.x, moveInput.z, moveInput.y) * moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * rotateInput.x * turnSpeed * Time.deltaTime);




    }

}
