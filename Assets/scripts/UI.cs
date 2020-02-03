using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
	public GameObject panel;
	public GameObject Manager;

	private void Start()
	{
		Time.timeScale = 1;
	}

	public void Resume()
	{

		Manager.SetActive(true);
		panel.SetActive(false);
	}

	public void Pause()
	{
		Manager.SetActive(false);
		panel.SetActive(true);
	}

	public void LoadScene(int i)
	{
		SceneManager.LoadScene(i);
	}
}
