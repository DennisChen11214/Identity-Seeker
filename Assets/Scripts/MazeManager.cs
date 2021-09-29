using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeManager : MonoBehaviour
{
    [SerializeField] List<GameObject> frontFaceWalls;
    [SerializeField] List<GameObject> backFaceWalls;
    [SerializeField] List<GameObject> topFaceWalls;    
    [SerializeField] List<GameObject> bottomFaceWalls;
    [SerializeField] List<GameObject> leftFaceWalls;
    [SerializeField] List<GameObject> rightFaceWalls;
    [SerializeField] GameObject startBlock;
    [SerializeField] GameObject endBlock;
    [SerializeField] Material startMat;
    [SerializeField] Material normalMat;
    [SerializeField] Material selectedMat;
    [SerializeField] GameObject maze;
    GameObject currentBlock;
    int curRow = 2;
    int curCol = 2;
    int currentFace = 0; //Front: 0, Back: 1, Top: 2, Bottom: 3, Left: 4, Right: 5
    int prevFace = 0;
    PlayerControls controls;
    Vector3 center = Vector3.zero;

    private void Awake() {
        controls = new PlayerControls();
        controls.Maze.Up.performed += ctx => MoveUp();
        controls.Maze.Down.performed += ctx => MoveDown();
        controls.Maze.Left.performed += ctx => MoveLeft();
        controls.Maze.Right.performed += ctx => MoveRight();
    }

    private void Start() {
        currentBlock = startBlock;
        currentBlock.GetComponent<Renderer>().material = selectedMat;
    }

    private void Update() {
    }

    void Move(Vector3 rayCastDir, Vector3 moveDir){
        RaycastHit hit = new RaycastHit();
        if(!Physics.Raycast(currentBlock.transform.position, rayCastDir, out hit)) return;
        prevFace = currentFace;
        switch (hit.collider.gameObject.tag)
        {
            case "Top":
                currentFace = 2;
                break;
            case "Bottom":
                currentFace = 3;
                break;
            case "Back":
                currentFace = 1;
                break;
            case "Front":
                currentFace = 0;
                break;
            case "Left":
                currentFace = 4;
                break;
            case "Right":
                currentFace = 5;
                break;
            case "Wall":
                return;
            case "Block":
                if(currentBlock == startBlock){
                    currentBlock.GetComponent<Renderer>().material = startMat;
                }
                else{
                    currentBlock.GetComponent<Renderer>().material = normalMat;
                }
                currentBlock = hit.collider.gameObject;
                currentBlock.GetComponent<Renderer>().material = selectedMat;
                if(currentBlock == endBlock){
                    BackToHUB();
                }
                return;
        }
        StartCoroutine(MoveMaze(moveDir));
    }

    IEnumerator MoveMaze(Vector3 axis){
        maze.transform.RotateAround(center, axis, 90);
        TurnOnOffWalls(prevFace, false);
        TurnOnOffWalls(currentFace, true);
        yield return null;
    }

    void MoveUp(){
        Move(Vector3.up, Vector3.right);
    }

    void MoveDown(){
        Move(Vector3.down, Vector3.left);
    }

    void MoveLeft(){
        Move(Vector3.right, Vector3.down);
    }

    void MoveRight(){
        Move(Vector3.left, Vector3.up);
    }

    void TurnOnOffWalls(int wall, bool on){
        switch (wall)
        {
            case 0:
                for(int i = 0; i < frontFaceWalls.Count; i++){
                    frontFaceWalls[i].SetActive(on);
                }
                break;
            case 1:
                for(int i = 0; i < backFaceWalls.Count; i++){
                    backFaceWalls[i].SetActive(on);
                }
                break;
            case 2:
                for(int i = 0; i < topFaceWalls.Count; i++){
                    topFaceWalls[i].SetActive(on);
                }
                break;
            case 3:
                for(int i = 0; i < bottomFaceWalls.Count; i++){
                    bottomFaceWalls[i].SetActive(on);
                }
                break;
            case 4:
                for(int i = 0; i < leftFaceWalls.Count; i++){
                    leftFaceWalls[i].SetActive(on);
                }
                break;
            case 5:
                for(int i = 0; i < rightFaceWalls.Count; i++){
                    rightFaceWalls[i].SetActive(on);
                }
                break;
        }
    }

    public void BackToHUB(){
        SceneManager.LoadScene("Menu");
    }

    private void OnEnable() {
        controls.Maze.Enable();
    }

    private void OnDisable() {
        controls.Maze.Disable();
    }
}
