using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class webCamScript : MonoBehaviour
{
    public GameObject webCameraPlane;
    public Button fireButton;
    private Vector3 throwForce = new Vector3(0, 10, 0);

    // Start is called before the first frame update
    void Start()
    {
        if (Application.isMobilePlatform)
        {
            GameObject cameraParent = new GameObject("camParent");
            cameraParent.transform.position = this.transform.position;
            this.transform.parent = cameraParent.transform;
            cameraParent.transform.Rotate(Vector3.right, 90);
        }

        Input.gyro.enabled = true;


       

        WebCamTexture webCameraTexture = new WebCamTexture();
        webCameraPlane.GetComponent<MeshRenderer>().material.mainTexture = webCameraTexture;
        webCameraTexture.Play();
        fireButton.onClick.AddListener(OnButtonDown);

    }

    void OnButtonDown()
    {

        GameObject bullet = Instantiate(Resources.Load("bullet", typeof(GameObject))) as GameObject;
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        bullet.transform.rotation = Camera.main.transform.rotation;
        bullet.transform.position = Camera.main.transform.position;
        rb.AddForce(Camera.main.transform.forward * 3000f);
        Destroy(bullet, 1);

        GetComponent<AudioSource>().Play();


    }


    // Update is called once per frame
    void Update()
    {
        Quaternion cameraRotation = new Quaternion(Input.gyro.attitude.x, Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w);
        this.transform.localRotation = cameraRotation;

        if (GameObject.FindGameObjectsWithTag("Player").Length == 0)
        {
            string i = "lara a des idées bizaresesscdecscelle est tres étrange ?";
            
            GameObject ObjectTest = Instantiate(Resources.Load("ObjectTest", typeof(GameObject))) as GameObject;
            ObjectTest.GetComponent<Transform>().position.Set(Random.Range(-2,2),-3, 6);
            ObjectTest.GetComponent<Rigidbody>().AddForce(throwForce, ForceMode.Impulse);

        }
    }
}
