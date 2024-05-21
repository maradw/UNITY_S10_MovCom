using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private float _horizontal;
    private float _vertical;
    [SerializeField] private Rigidbody myRBD;
    [SerializeField] private float velocityModifier = 5f;
    [SerializeField] private GameObject proyectile;
    private Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnMovement(InputAction.CallbackContext move)
    {
        _horizontal = move.ReadValue<Vector2>().x;
        _vertical = move.ReadValue<Vector2>().y;
        

    }
    public void OnShoot(InputAction.CallbackContext shoot)
    {
        Instantiate(proyectile, transform.position, Quaternion.identity);

    }
    public void OnClick(InputAction.CallbackContext click)
    {
        if (click.performed)
        {
            Debug.Log("¡El botón ha sido presionado!");

        }
    } 
    void OnPosition(InputAction.CallbackContext context)
    {
        Vector2 mousePosition = context.ReadValue<Vector2>();
        // Aquí puedes manejar la posición del ratón
    }
    public void FixedUpdate()
    {
        myRBD.velocity = new Vector3(_horizontal * velocityModifier, myRBD.velocity.y, _vertical * velocityModifier);
    }
    public void GetTransform()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
