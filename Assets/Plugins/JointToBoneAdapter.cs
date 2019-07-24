using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kinect = Windows.Kinect;

public static class JointToBoneAdapter
{
    public static Dictionary<Kinect.JointType, HumanBodyBones> j_b_pair = new Dictionary<Kinect.JointType, HumanBodyBones>()
    {
        {Kinect.JointType.Head, HumanBodyBones.Head },
        {Kinect.JointType.Neck, HumanBodyBones.Neck },
        {Kinect.JointType.SpineShoulder, HumanBodyBones.UpperChest },
        {Kinect.JointType.SpineMid, HumanBodyBones.Chest },
        {Kinect.JointType.SpineBase, HumanBodyBones.Spine },

        {Kinect.JointType.ShoulderLeft, HumanBodyBones.RightUpperArm },
        {Kinect.JointType.ElbowLeft, HumanBodyBones.RightLowerArm },
        //{Kinect.JointType.WristLeft, HumanBodyBones.RightHand },

        {Kinect.JointType.ShoulderRight, HumanBodyBones.LeftUpperArm },
        {Kinect.JointType.ElbowRight, HumanBodyBones.LeftLowerArm },
        //{Kinect.JointType.WristRight, HumanBodyBones.LeftHand },

        {Kinect.JointType.HipLeft, HumanBodyBones.RightUpperLeg },
        {Kinect.JointType.KneeLeft, HumanBodyBones.RightLowerLeg },
        {Kinect.JointType.AnkleLeft, HumanBodyBones.RightFoot },
        {Kinect.JointType.FootLeft, HumanBodyBones.RightToes },

        {Kinect.JointType.HipRight, HumanBodyBones.LeftUpperLeg },
        {Kinect.JointType.KneeRight, HumanBodyBones.LeftLowerLeg },
        {Kinect.JointType.AnkleRight, HumanBodyBones.LeftFoot },
        {Kinect.JointType.FootRight, HumanBodyBones.LeftToes },
    };
}
