using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LineRenderers : MonoBehaviour {

    private LineRenderer lineRenderer;
    private float fps;

    GameObject rightController;
    GameObject leftController;
    GLDebug glDebug;

    // Use this for initialization
    void Awake() {
        if (lineRenderer == null) {
            lineRenderer = GetComponent<LineRenderer>();
        }
        //Get references to other objects
        rightController= GameObject.Find("Controller (right)");
        leftController = GameObject.Find("Controller (left)");
        glDebug = GetComponent<GLDebug>();
        Debug.Log("RightController " + rightController);
        Debug.Log("LeftController " + leftController);
    }
	
	// Update is called once per frame
	void Update () {
        createLines();
	}

    void createLines() {

        //GLDebug.DrawLine(leftController.transform.position, transform.position);
        //GLDebug.DrawLine(transform.position, rightController.transform.position);
        CreateLineRenderers();
        lineRenderer.numPositions = 2;

        int i = 0;

        lineRenderer.enabled = true;
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;

        lineRenderer.SetPosition(i++, new Vector3(5,0,0));
        lineRenderer.SetPosition(i++, new Vector3(0,0,0));
        //lineRenderer.SetPosition(i++, rightController.transform.position);

    }

    void CreateLineRenderers() {
        if (lineRenderer == null) {
            lineRenderer = GetComponent<LineRenderer>();
            if (lineRenderer == null) {
                lineRenderer = gameObject.AddComponent<LineRenderer>();
            }
        }
        if (lineRenderer == null) {
            lineRenderer = GetComponent<LineRenderer>();
        }
    }
}
