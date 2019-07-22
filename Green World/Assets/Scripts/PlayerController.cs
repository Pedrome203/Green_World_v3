using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text countText;
    public Text winText;
    private int count;
    public float gravity = 10f;
    public float speed = 3.5f;
 
    private CharacterController controller; 

    void Start()
    {
        controller= GetComponent<CharacterController>();
    }
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        Vector3 velocity = direction * speed;
        velocity = Camera.main.transform.TransformDirection(velocity);
        velocity.y -= gravity;
        controller.Move(velocity * Time.deltaTime);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemigo"))
        {
            other.gameObject.SetActive(false);
            count++;
            setCountText();
        }
    }
    void setCountText()
    {
        countText.text = "Puntaje: " + count.ToString();
        if (count == 100)
        {
            winText.text = "Haz salvado al mundo :)";
        }
    }




}
