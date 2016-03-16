using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour
{	
	[SerializeField] private Text scoreLabel;
	[SerializeField] private SettingsPopup settingsPopup;
	private int _score;

	void Start() {
		_score = 0;
		scoreLabel.text = _score.ToString();
		settingsPopup.Close();
	}		

	public void OnOpenSettings () {
		settingsPopup.Open (); 
	}

	void Awake() {
		Messenger.AddListener(GameEvent.ENEMY_HIT, OnEnemyHit);
	}

	void OnDestroy() {
		Messenger.RemoveListener(GameEvent.ENEMY_HIT, OnEnemyHit);
	}

	private void OnEnemyHit() {
		_score += 1;
		scoreLabel.text = _score.ToString();
	}
}