using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	// Triggers
	public Renderer leftTriggerSphere;
	public Renderer rightTriggerSphere;

	// Bumpers
	public Renderer leftBumperBox;
	public Renderer rightBumperBox;

	// Buttons
	public Renderer aButtonSphere;
	public Renderer bButtonSphere;
	public Renderer xButtonSphere;
	public Renderer yButtonSphere;

	// DPad
	public Renderer dpadLeft;
	public Renderer dpadUp;
	public Renderer dpadRight;
	public Renderer dpadDown;

	// Start and Back
	public Renderer startBox;
	public Renderer backBox;

	// Joysticks
	public Transform cubeLS;
	public Transform cubeRS;
	float movementSpeed = 2.0f;

	void Update(){
		float rTriggerFloat = Input.GetAxis("Right Trigger");
		float lTriggerFloat = Input.GetAxis("Left Trigger");
		bool leftBumper = Input.GetButton("Left Bumper");
		bool rightBumper = Input.GetButton("Right Bumper");
		bool backButton = Input.GetButton("Back");
		bool startButton = Input.GetButton("Start");
		bool aButton = Input.GetButton("A Button");
		bool bButton = Input.GetButton("B Button");
		bool xButton = Input.GetButton("X Button");
		bool yButton = Input.GetButton("Y Button");
		float dpadHorizontal = Input.GetAxis("Dpad Horizontal") * movementSpeed;
		float dpadVertical = Input.GetAxis("Dpad Vertical") * movementSpeed;
		float moveHL = Input.GetAxis("Horizontal") * movementSpeed;
		float moveVL = Input.GetAxis("Vertical") * movementSpeed;
		//float moveHR = Input.GetAxis("Mouse X") * movementSpeed;
		//float moveVR = Input.GetAxis("Mouse Y") * movementSpeed;
		float moveHR = Input.GetAxis("Horizontal Axis") * movementSpeed;
		float moveVR = Input.GetAxis("Vertical Axis") * movementSpeed;

		// Colors for Trigger Spheres
		rightTriggerSphere.material.color = new Color(rTriggerFloat,rTriggerFloat,rTriggerFloat);
		leftTriggerSphere.material.color = new Color(lTriggerFloat,lTriggerFloat,lTriggerFloat);

		// Dpad
		if(dpadHorizontal < 0){
			dpadLeft.material.color = new Color(1,1,1);
			dpadRight.material.color = new Color(0,0,0);
		}else if(dpadHorizontal > 0){
			dpadRight.material.color = new Color(1,1,1);
			dpadLeft.material.color = new Color(0,0,0);
		}else if(dpadHorizontal == 0){
			dpadRight.material.color = new Color(0,0,0);
			dpadLeft.material.color = new Color(0,0,0);
		}

		if(dpadVertical < 0){
			dpadDown.material.color = new Color(1,1,1);
			dpadUp.material.color = new Color(0,0,0);
		}else if(dpadVertical > 0){
			dpadUp.material.color = new Color(1,1,1);
			dpadDown.material.color = new Color(0,0,0);
		}else if(dpadVertical == 0){
			dpadUp.material.color = new Color(0,0,0);
			dpadDown.material.color = new Color(0,0,0);
		}

		// Bumpers
		if(leftBumper){
			leftBumperBox.material.color = new Color(1,1,1);
		}else if(!leftBumper){
			leftBumperBox.material.color = new Color(0,0,0);
		}
		if(rightBumper){
			rightBumperBox.material.color = new Color(1,1,1);
		}else if(!rightBumper){
			rightBumperBox.material.color = new Color(0,0,0);
		}

		// A,B,X,Y
		if (aButton){
			aButtonSphere.material.color = new Color(1,1,1);
		}else if(!aButton){
			aButtonSphere.material.color = new Color(0,0,0);
		}
		if(bButton){
			bButtonSphere.material.color = new Color(1,1,1);
		}else if(!bButton){
			bButtonSphere.material.color = new Color(0,0,0);
		}
		if(xButton){
			xButtonSphere.material.color = new Color(1,1,1);
		}else if(!xButton){
			xButtonSphere.material.color = new Color(0,0,0);
		}
		if(yButton){
			yButtonSphere.material.color = new Color(1,1,1);
		}else if(!yButton){
			yButtonSphere.material.color = new Color(0,0,0);
		}

		// Back and Start Buttons
		if(backButton){
			backBox.material.color = new Color(1,1,1);
		}else if(!backButton){
			backBox.material.color = new Color(0,0,0);
		}
		if(startButton){
			startBox.material.color = new Color(1,1,1);
		}else if(!backButton){
			startBox.material.color = new Color(0,0,0);
		}

		// Movement in per second measurements
		moveHL *= Time.deltaTime;
		moveVL *= Time.deltaTime;
		moveHR *= Time.deltaTime;
		moveVR *= Time.deltaTime;

		// Move cube with Left Joystick and Right Joystick
		cubeLS.Translate(moveVL,0,moveHL);
		cubeRS.Translate(moveVR,0,moveHR);
	}
}
