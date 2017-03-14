using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	private float panSpeedInZoom = 2.0f;
	public Camera cam;
	public float panSpeed = 0.1f;
	bool rotating = false;

	void Update () {

		float scroll = Input.GetAxis("Mouse ScrollWheel");
		cam.orthographicSize += scroll * panSpeedInZoom;

		if (cam.orthographicSize >= 5) {
			cam.orthographicSize = 5;
		}
		if (cam.orthographicSize <= 1) {
			cam.orthographicSize = 1;
		}

		if (cam.orthographicSize > 1 && cam.orthographicSize > 3) {
			panSpeed = 0.05f;
		} else {
			panSpeed = 0.1f;
		}

			
		if (Input.GetKey (KeyCode.D) && rotating == false) {
			transform.Translate (panSpeed, 0, -panSpeed);
		}
		if (Input.GetKey (KeyCode.A) && rotating == false) {
			transform.Translate (-panSpeed, 0, panSpeed);
		}
		if (Input.GetKey (KeyCode.W) && rotating == false) {
			transform.Translate (0, panSpeed, 0);
		}
		if (Input.GetKey (KeyCode.S) && rotating == false) {
			transform.Translate (0, -panSpeed, 0);
		}

		if (Input.GetMouseButton (1)) {
			rotating = true;
			transform.Rotate (0, Input.GetAxis("Mouse X") * 5f, 0, Space.World);
		}

		if (Input.GetMouseButtonUp (1)) {
			rotating = false;
			if (transform.eulerAngles.y <= 45f && transform.eulerAngles.y >= 0f) {
				transform.Rotate (0, -transform.eulerAngles.y, 0);
			}
			if (transform.eulerAngles.y <= 90f && transform.eulerAngles.y >= 45f) {
				transform.Rotate (0, -transform.eulerAngles.y + 90, 0);
			}
			if (transform.eulerAngles.y <= 135f && transform.eulerAngles.y >= 90f) {
				transform.Rotate (0, -transform.eulerAngles.y + 90, 0);
			}
			if (transform.eulerAngles.y <= 180f && transform.eulerAngles.y >= 135f) {
				transform.Rotate (0, -transform.eulerAngles.y + 180, 0);
			}
			if (transform.eulerAngles.y <= 225f && transform.eulerAngles.y >= 180f) {
				transform.Rotate (0, -transform.eulerAngles.y + 180, 0);
			}
			if (transform.eulerAngles.y <= 270f && transform.eulerAngles.y >= 225f) {
				transform.Rotate (0, -transform.eulerAngles.y + 270, 0);
			}
			if (transform.eulerAngles.y <= 315f && transform.eulerAngles.y >= 270f) {
				transform.Rotate (0, -transform.eulerAngles.y + 270, 0);
			}
			if (transform.eulerAngles.y <= 360f && transform.eulerAngles.y >= 315f) {
				transform.Rotate (0, -transform.eulerAngles.y, 0);
			}

		}
	}
}
