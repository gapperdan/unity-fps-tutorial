using UnityEngine;
using System.Collections;

public class SettingsPopup : MonoBehaviour {
	public void Open() {
		gameObject.SetActive(true);
	}
	public void Close() {
		gameObject.SetActive(false);
	}
}