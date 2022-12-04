using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Timeline.AnimationPlayableAsset;


public class PlayerMove3D : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    private float changeSpot;
    private float inputX;

    
    public float sensitivityX = 15F;
    public float sensitivityY = 15F;

    public float minimumX = -360F;
    public float maximumX = 360F;

    public float minimumY = -60F;
    public float maximumY = 60F;

    float rotationX = 0F;
    float rotationY = 0F;

    public GameObject pauseMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;//Target the frame rate to about 300fps
        QualitySettings.vSyncCount = 0;
        // Cursor.lockState = CursorLockMode.Locked;
        Cursor.lockState = CursorLockMode.Locked;
        //Cursor.lockState = CursorLockMode.Confined;
        //Cursor.visible = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.GameIsPaused) {
            inputX = Input.GetAxis("Horizontal");
            float inputY = Input.GetAxis("Vertical");
            Vector3 moveVect = new Vector3(inputX, 0, inputY);
            moveVect *= (moveSpeed * Time.deltaTime);
        
            transform.Translate(moveVect);


            rotationX += Input.GetAxis("Mouse X") * sensitivityX;
            rotationY += Input.GetAxis("Mouse Y") * sensitivityY;


            rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

            transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
        }
    }
}
