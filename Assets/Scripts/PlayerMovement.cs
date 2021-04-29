using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController), typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    NewInput inputs;
    [Header("Movement")]
    [SerializeField] [Range(1f, 10f)] float speed = 3f;

    [Header("Jump")]
    [SerializeField] [Range(1f, 5f)] float jumpHeight = 5f;
    [SerializeField] float gravity = -9.81f;
    [SerializeField] float distToGround = 1f;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundMask;

    float colliderRadius;
    public float ColliderRadius
    {
        get { return colliderRadius; }
    }

    bool isGrounded;
    bool isMove = true;
    public bool IsMove
    {
        get { return isMove; }
        set { isMove = value; }
    }
    Vector3 velocity;
    Vector2 move;

    CharacterController controller;

    private void Awake()
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Rigidbody>().useGravity = false;

        controller = GetComponent<CharacterController>();

        colliderRadius = controller.radius;

        inputs = new NewInput();
        inputs.Player.Movement.performed += ctx => move = ctx.ReadValue<Vector2>();
        inputs.Player.Movement.canceled += ctx => move = Vector2.zero;
    }

    private void OnEnable()
    {
        inputs.Player.Enable();
    }

    private void OnDisable()
    {
        inputs.Player.Disable();
    }

    void Update()
    {
        Move();
    }

    public void Move()
    {
        if (isMove)
        {
            isGrounded = Physics.CheckSphere(groundCheck.position, distToGround, groundMask);

            if (isGrounded && velocity.y < 0)
            {
                velocity.y = -2;
            }


            Vector3 direction = transform.right * move.x + transform.forward * move.y;
            controller.Move(direction * speed * Time.deltaTime);

            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if (isGrounded)
            {
                velocity.y += Mathf.Sqrt(jumpHeight * -2f * gravity);
                isGrounded = false;
            }
        }
    }

    public void OnInteraction(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Transform cam = GetComponentInChildren<Camera>().transform;
            Ray ray = new Ray(cam.position, cam.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 2f))
            {
                if (hit.collider.gameObject.CompareTag("Console"))
                {
                    isMove = false;

                    GameManager.instance.StartGame(hit.collider.gameObject);
                }
            }
        }
    }
}
