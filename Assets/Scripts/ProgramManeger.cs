using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ProgramManeger : MonoBehaviour
{
    [Header("Put your PlaneMarker here!")]
    [SerializeField] private GameObject PlaneMarkerPrefab;
    private ARRaycastManager ARRaycastManagerScript;
    private Vector2 TouchPosition;
    public GameObject ObjectToSpawn;
    public GameObject Cam;
    public GameObject Triger;
    void Start()
    {
        ARRaycastManagerScript = FindObjectOfType<ARRaycastManager>();
        PlaneMarkerPrefab.SetActive(false);
        Triger.transform.position = new Vector2(Screen.width / 2, Screen.height / 2);
    }

    // Update is called once per frame
    void Update()
    {
        

        Ray ray = new Ray(Cam.transform.position, Cam.transform.forward);
        Debug.DrawRay(Cam.transform.position, Cam.transform.forward*100f, Color.yellow);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Triger.GetComponent<UnityEngine.UI.Image>(). color = Color.red;
        } else 
        {
        Triger.GetComponent<UnityEngine.UI.Image>(). color = Color.white;
        }
        

    }
    public void Fire()
    {
        Ray ray = new Ray(Cam.transform.position, Cam.transform.forward);
        Debug.DrawRay(Cam.transform.position, Cam.transform.forward*100f, Color.yellow);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            GameObject obj = hit.collider.gameObject;
            obj.GetComponent<HealthBarEnemy>().Damage();

        }
    }
    public void SetClone()
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        ARRaycastManagerScript.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);
            Debug.Log(Input.GetTouch(0).position);
            Instantiate(ObjectToSpawn, hits[0].pose.position, ObjectToSpawn.transform.rotation);
    }
}
