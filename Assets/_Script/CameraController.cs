using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position;
	}
	
	// Unity中Update和Lateupdate的区别。Lateupdate和Update每一祯都被执行，
	// 但是执行顺序不一样，先执行Updatee然后执行lateUpdate。
	void LateUpdate(){
		transform.position = player.transform.position + offset;
	}
}
