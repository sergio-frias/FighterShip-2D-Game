using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float maxSpeed = 3f;
    public float rotationSpeed = 180f;

    float jetBoundaryCushion = 0.6f;
    public float movingBoundary;
    public float movingBoundary2;

    // Start is called before the first frame update
    void Start()
    {
        movingBoundary = Camera.main.orthographicSize;
        movingBoundary2 = -movingBoundary;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rotate = transform.rotation;

        float z = rotate.eulerAngles.z;
        z += -Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        rotate = Quaternion.Euler(0, 0, z);
        transform.rotation = rotate;

        
        Vector3 pos = transform.position;
        Vector3 posChange = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);

        pos += rotate * posChange;

        

        movingBoundary += 0.01f;
        movingBoundary2 += 0.01f;
        
        if (pos.y + jetBoundaryCushion > movingBoundary )
        {
            pos.y = movingBoundary - jetBoundaryCushion;
        }
        if (pos.y - jetBoundaryCushion < movingBoundary2)
        {
            pos.y = movingBoundary2 + jetBoundaryCushion;
        }

        if (pos.y > 130f)
            SceneManager.LoadScene("YouWin");



        
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;

        //Horizontal Boundaries
        if (pos.x + jetBoundaryCushion > widthOrtho)
        {
            pos.x = widthOrtho - jetBoundaryCushion;
        }
        if (pos.x - jetBoundaryCushion < -widthOrtho)
        {
            pos.x = -widthOrtho + jetBoundaryCushion;
        }

        transform.position = pos;

    }
}
