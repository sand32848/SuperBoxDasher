using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    private InputTaker inputTaker;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        inputTaker = GetComponent<InputTaker>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

	private void FixedUpdate()
	{
        MovePlayer(inputTaker.movement.ReadValue<Vector2>());
    }

	public void MovePlayer(Vector2 dir = new Vector2())
	{
        rb.velocity = dir * speed  * Time.deltaTime;
	}
}
