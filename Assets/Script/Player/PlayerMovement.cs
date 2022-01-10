using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    private InputController inputController;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        inputController = GetComponent<InputController>();
    }

	private void FixedUpdate()
	{
        MovePlayer(inputController.movement);
    }

	public void MovePlayer(Vector2 dir = new Vector2())
	{
        rb.velocity =new Vector2(0,0) * Time.deltaTime;
	}
}
