using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public InteractiveElement right;
    public InteractiveElement left;
    public Text livesText, scoreText;
    [SerializeField] string livesTemplate, scoreTemplate;
    [SerializeField] Animator animator;
    [SerializeField] float moveSpeed;
    private float lives = 3, score = 0;

    private void Start()
    {
        animator = GetComponent<Animator>();
        livesText.text = livesTemplate + lives;
        scoreText.text = scoreTemplate + score;
    }
    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Hazard")
        {
            lives--;
            livesText.text = livesTemplate + lives;
            Destroy(other.gameObject);
        }
        if(other.tag == "Collectible")
        {
            score += 10;
            scoreText.text = scoreTemplate + score;
            Destroy(other.gameObject);
        }
    }

    private void HandleMovement()
    {
        if ((right.isPressed && left.isPressed) || (!right.isPressed && !left.isPressed))
        {
            animator.SetBool("Walking", false);
            return;
        }
        if(right.isPressed)
        {
            animator.SetBool("Walking", true);
            transform.localScale = new Vector3(1,1,1);
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        if (left.isPressed)
        {
            animator.SetBool("Walking", true);
            transform.localScale = new Vector3(-1, 1, 1);
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
    }
}
