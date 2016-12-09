using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    public static GameControl control;

    private Text[] texts;  //  controllers index, transforms
    private Text text1;
    private Text text2;
    private Text text3;
    private Text text4;
    private GameObject camerRig;
    private SteamVR_TrackedObject left;
    private SteamVR_TrackedObject right;

    // Use this for initialization
    void Awake () {
        if (control == null) {
            DontDestroyOnLoad(gameObject);
        } else if (control != this) {
            Destroy(gameObject);
        }

        GameObject canvas = GameObject.Find(Constants.CANVAS);
        Debug.Log(canvas);
        if (canvas) {
            texts = new Text [4];
            int i = 0;
            var text1_ = canvas.transform.Find(Constants.TEXT1).gameObject;
            Debug.Log("pos " + i + " " + text1_.transform.position);
            text1 = text1_.transform.GetComponent<UnityEngine.UI.Text>();
            texts[i++] = text1;
            //var go = Instantiate(text1);
            //go.transform.position = new Vector3(text1_.transform.position.x, text1_.transform.position.y - (i * 25.0f) , text1_.transform.position.z);
            //Debug.Log("pos " + i + " " + go.transform.position);
            //texts[i++] = go.transform.GetComponent<UnityEngine.UI.Text>();
            //go = Instantiate(text1);
            //go.transform.position = new Vector3(text1_.transform.position.x, text1_.transform.position.y - (i * 25.0f), text1_.transform.position.z);
            //Debug.Log("pos " + i + " " + go.transform.position);
            //texts[i++] = go.transform.GetComponent<UnityEngine.UI.Text>();
            //go = Instantiate(text1);
            //go.transform.position = new Vector3(text1_.transform.position.x, text1_.transform.position.y - (i * 25.0f), text1_.transform.position.z);
            //Debug.Log("pos " + i + " " + go.transform.position);
            //texts[i++] = go.transform.GetComponent<UnityEngine.UI.Text>();

            var text2_ = canvas.transform.Find(Constants.TEXT2).gameObject;
            Debug.Log("pos " + i + " " + text2_.transform.position);
            text2 = text2_.transform.GetComponent<UnityEngine.UI.Text>();
            texts[i++] = text2;

            var text3_ = canvas.transform.Find(Constants.TEXT3).gameObject;
            Debug.Log("pos " + i + " " + text3_.transform.position);
            text3 = text3_.transform.GetComponent<UnityEngine.UI.Text>();
            texts[i++] = text3;

            var text4_ = canvas.transform.Find(Constants.TEXT4).gameObject;
            Debug.Log("pos " + i + " " + text4_.transform.position);
            text4 = text4_.transform.GetComponent<UnityEngine.UI.Text>();
            texts[i++] = text4;
        }

        GameObject cameraRig = GameObject.Find(Constants.CAMERARIG);
        Debug.Log(cameraRig);
        var controllerManager = cameraRig.GetComponent<SteamVR_ControllerManager>();
        var leftGo = controllerManager.left;
        left = leftGo.GetComponent<SteamVR_TrackedObject>();
        var rightGo = controllerManager.right;
        right = rightGo.GetComponent<SteamVR_TrackedObject>();
        Debug.Log("Left" + left.index);
        Debug.Log("Right" + right.index);
    }
	
	// Update is called once per frame
	void Update () {
        text1.text = (left.index != SteamVR_TrackedObject.EIndex.None) ? "Left controller found @ index " + left.index : "Left controller not found";
        text2.text = (right.index != SteamVR_TrackedObject.EIndex.None) ? "Right controller found @ index " + right.index : "Right controller not found";
        text3.text = (left.index != SteamVR_TrackedObject.EIndex.None) ? "Left controller transform " + left.transform.position.ToString("F3") : "Left controller not found";
        text4.text = (right.index != SteamVR_TrackedObject.EIndex.None) ? "Right controller transform " + right.transform.position.ToString("F3") : "Right controller not found";
    }

    
}
