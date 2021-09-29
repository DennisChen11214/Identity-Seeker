using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformerMovement : MonoBehaviour
{

    public enum MovementType{
        NORMAL,
        GLIDE,
        MOREJUMPS,
        TELEPORT,
        GRAVITY
    }

    public float speed;
    public float jumpForce;
    public float fallMultiplier;
    public float lowJumpMultiplier;
    public int extraJumps;
    public MovementType movementType;
    [SerializeField] int id;
    [SerializeField] Transform normalPos;
    [SerializeField] Transform crouchPos;
    [SerializeField] GameObject teleportText;
    Rigidbody2D rb;
    BoxCollider2D col2D;
    PlayerControls controls;
    Animator animator;
    int jumpsLeft;
    float telePortDistance;
    float horizontal;
    float vertical;
    float distToGround;
    bool gliding;
    bool crouching;
    bool teleporting;
    float durationHeld;
    int score;
    
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        col2D = GetComponent<BoxCollider2D>();
        controls = new PlayerControls();
        animator = GetComponent<Animator>();
        if(id == 1){
            controls.PlatformerPlayer1.MovementX.performed += ctx => horizontal = ctx.ReadValue<float>();
            controls.PlatformerPlayer1.MovementX.canceled += ctx => horizontal = 0;
            controls.PlatformerPlayer1.MovementY.performed += ctx => vertical = ctx.ReadValue<float>();
            controls.PlatformerPlayer1.MovementY.canceled += ctx => vertical = 0;
            controls.PlatformerPlayer1.Jump.performed += ctx => Jump();
            controls.PlatformerPlayer1.Jump.performed += ctx => Glide(true);
            controls.PlatformerPlayer1.Jump.canceled += ctx => Glide(false);
        }
        else if(id == 2){
            controls.PlatformerPlayer2.MovementX.performed += ctx => horizontal = ctx.ReadValue<float>();
            controls.PlatformerPlayer2.MovementX.canceled += ctx => horizontal = 0;
            controls.PlatformerPlayer2.MovementY.performed += ctx => vertical = ctx.ReadValue<float>();
            controls.PlatformerPlayer2.MovementY.canceled += ctx => vertical = 0;
            controls.PlatformerPlayer2.Jump.performed += ctx => Jump();
            controls.PlatformerPlayer2.Jump.performed += ctx => Glide(true);
            controls.PlatformerPlayer2.Jump.canceled += ctx => Glide(false);
        }
    }

    private void Start() {
        distToGround = GetComponent<Collider2D>().bounds.extents.y;
        //movementType = (MovementType) Random.Range(0,5);
        if(movementType == MovementType.MOREJUMPS){
            speed *= 0.7f;
            extraJumps = 1;
        }
        else if(movementType == MovementType.GLIDE){
            jumpForce *= 1.5f;
        }
        jumpsLeft = extraJumps;
        PlayerPrefs.SetInt("Player" + id, 0);
        if(id == 1){
            if(movementType == MovementType.TELEPORT){
                controls.PlatformerPlayer1.Jump.performed += ctx => ToggleTeleporting();
                controls.PlatformerPlayer1.Jump.canceled += ctx => Teleport();
            }
            
        }
        else if(id == 2){
            if(movementType == MovementType.TELEPORT){
                controls.PlatformerPlayer2.Jump.performed += ctx => ToggleTeleporting();
                controls.PlatformerPlayer2.Jump.canceled += ctx => Teleport();
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        if(teleporting){
            if(durationHeld % 2 < 0.1f){
                teleportText.GetComponent<Text>().text = "";
            }
            else if(durationHeld % 2 < 0.5f){
                teleportText.GetComponent<Text>().text = "1";
            }
            else if(durationHeld % 2 < 1){
                teleportText.GetComponent<Text>().text = "2";
            }
            else if(durationHeld % 2 < 1.5f){
                teleportText.GetComponent<Text>().text = "3";
            }
            else{
                teleportText.GetComponent<Text>().text = "4";
            }
            durationHeld += Time.fixedDeltaTime;
        }
        if(movementType == MovementType.NORMAL || movementType == MovementType.MOREJUMPS)
            Crouch();
        if(!IsGrounded()){
            if (rb.velocity.y < 0) {
                rb.velocity += Vector2.up * Physics2D.gravity * (fallMultiplier - 1) * Time.deltaTime * rb.gravityScale;
                if(gliding && movementType == MovementType.GLIDE) rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y / 1.5f);
            }
            else if (rb.velocity.y > 0) {
                rb.velocity += Vector2.up * Physics2D.gravity * (lowJumpMultiplier - 1) * Time.deltaTime * rb.gravityScale;
            }
        }
        else{
            jumpsLeft = extraJumps;
        }
    }

    void Move(){
        switch (movementType)
        {
            case MovementType.NORMAL:
            case MovementType.MOREJUMPS:
            case MovementType.GRAVITY:
                rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
                break;
            case MovementType.GLIDE:
                if(!IsGrounded() && rb.velocity.y < 0) {
                    rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
                }
                else{
                    rb.velocity = new Vector2(0,rb.velocity.y);
                }
                break;
            case MovementType.TELEPORT:
                break;
        }
        if(Mathf.Abs(rb.velocity.x) < 0.1f || !IsGrounded()){
            animator.SetBool("idle", true);
        }
        else{
            animator.SetBool("idle", false);
        }
        if(rb.velocity.x < 0){
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if(rb.velocity.x > 0){
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }

    void Jump(){
        switch (movementType)
        {
            case MovementType.NORMAL:
            case MovementType.MOREJUMPS:
            case MovementType.GLIDE:
                if(IsGrounded() || jumpsLeft > 0){
                    rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                    jumpsLeft --;
                }
                break;
            case MovementType.GRAVITY:
                rb.gravityScale *= -1;
                GetComponent<SpriteRenderer>().flipY = rb.gravityScale == -1;
                break;
        }
    }

    void Glide(bool glide){
        gliding = glide;
    }

    void Crouch(){
        if(vertical < 0 && IsGrounded() && !crouching){
            crouching = true;
            animator.SetBool("crouch", true);
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.4f, transform.position.z);
            col2D.size = new Vector2(col2D.size.x, 0.9f);
        }
        else if((vertical >= 0 || !IsGrounded()) && crouching){
            RaycastHit2D leftHit = Physics2D.Raycast(new Vector3(transform.position.x - col2D.size.x / 2.2f, transform.position.y + col2D.offset.y, transform.position.z), Vector2.up, -col2D.offset.y + col2D.size.y);
            RaycastHit2D rightHit = Physics2D.Raycast(new Vector3(transform.position.x + col2D.size.x / 2.2f, transform.position.y + col2D.offset.y, transform.position.z), Vector2.up, -col2D.offset.y + col2D.size.y);
            if(!leftHit && !rightHit){
                crouching = false;
                animator.SetBool("crouch", false);
                col2D.size = new Vector2(col2D.size.x, 1.7f);
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.4f, transform.position.z);
            }
        }
    }

    bool IsGrounded(){
        RaycastHit2D leftHit = Physics2D.Raycast(new Vector3(transform.position.x - col2D.size.x / 2.2f, transform.position.y, transform.position.z), Vector2.down, distToGround + 0.1f);
        RaycastHit2D rightHit = Physics2D.Raycast(new Vector3(transform.position.x + col2D.size.x / 2.2f, transform.position.y, transform.position.z), Vector2.down, distToGround + 0.1f);
        return (leftHit || rightHit);
    }

    void ToggleTeleporting(){
        teleporting = true;
    }

    void Teleport(){
        if(durationHeld == 0){
            return;
        }
        Vector3 telePos = transform.position;
        if(durationHeld % 2 < 0.5f){
            telePortDistance = 1;
        }
        else if(durationHeld % 2 < 1){
            telePortDistance = 2;
        }
        else if(durationHeld % 2 < 1.5f){
            telePortDistance = 3;
        }
        else{
            telePortDistance = 4;
        }
        telePos += new Vector3(telePortDistance * horizontal, telePortDistance * vertical, transform.position.z);
        Collider2D[] hit = Physics2D.OverlapBoxAll(telePos, col2D.bounds.extents * 1.95f, 0);
        bool valid = true;
        for(int i = 0; i < hit.Length; i++){
            if(!(!hit[i] || hit[i].isTrigger || hit[i].attachedRigidbody == rb)){
                valid = false;
            }
        }
        if(valid){
            transform.position = telePos;
        }
        teleportText.GetComponent<Text>().text = "";
        durationHeld = 0;
        teleporting = false;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Coin"){
            score++;
            PlayerPrefs.SetInt("Player" + id, score);
            Destroy(other.gameObject);
            print(score);
        }
        else if(other.gameObject.tag == "Finish"){
            PlatformerManager.Instance.winner = id;
            PlatformerManager.Instance.SetupEnd();
        }   
    }

    private void OnEnable() {
        if(id == 1){
            controls.PlatformerPlayer1.Enable();
        }
        else if(id == 2){
            controls.PlatformerPlayer2.Enable();
        }
    }

    private void OnDisable() {
        if(id == 1){
            controls.PlatformerPlayer1.Disable();
        }
        else if(id == 2){
            controls.PlatformerPlayer2.Disable();
        }
    }
}
