using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Kinect = Windows.Kinect;

using WebSocketSharp;
using WebSocketSharp.Net;

public class JointDataManager : MonoBehaviour
{
    //[SerializeField] GameObject Avatar;
    Animator ani_;

    WebSocket ws;

    HumanBodyBones bb;
    Quaternion qq;
    // Start is called before the first frame update
    void Start()
    {
        ws = new WebSocket("ws://drumath-unity-web-socket.herokuapp.com");

        ws.OnOpen += Ws_OnOpen;
        ws.OnMessage += Ws_OnMessage;

        ani_ = GetComponent<Animator>();
        Debug.Log(ani_);

        ws.Connect();
    }

    private void Ws_OnMessage(object sender, MessageEventArgs e)
    {
        var data = JsonUtility.FromJson<TrackedJointData>(e.Data);
        var joint = data.JointName;
        Kinect.JointType type = Kinect.JointType.SpineBase;
        for (var j = Kinect.JointType.SpineBase; j <= Kinect.JointType.FootRight; j++)
        {
            if (j.ToString() == joint)
            {
                type = j;
            }
        }
        HumanBodyBones bone = JointToBoneAdapter.j_b_pair[type];

        Quaternion rot = new Quaternion(data.RotX, data.RotY, data.RotZ, data.RotW);

        ani_.GetBoneTransform(bone).rotation = rot;
    }

    private void Ws_OnOpen(object sender, System.EventArgs e)
    {
        Debug.Log("connected.");
    }

    // Update is called once per frame
    void Update()
    {
        //ani_.GetBoneTransform(bb).rotation = qq;
        //Debug.Log(qq);
        //Debug.Log(bb.ToString());
    }

    private void OnDestroy()
    {
        ws.Close();
    }
}
