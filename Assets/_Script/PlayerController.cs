using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	private int count;

	public Text countText;

	// Use this for initialization
	void Start () {
		count = 0;
		setCountText();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void setCountText(){
		countText.text = "Count: " + count;
	}
    
	//需要勾选 is Trigger 才会生效
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "PickUp"){
			// 设置对象不可见
			other.gameObject.SetActive(false);
            // 销毁对象
			//Destroy(other.gameObject);
			count++;
			setCountText();
		}
	}

	/* 
	 * FixedUpdate 是在固定的时间间隔去执行的，不受游戏帧率（fps）影响
	 * 设置时间间隔方法  Edit -> Project Setting -> Time 找到 Fixed timestep 修改即可
	 */
	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);

		GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
	}
}
