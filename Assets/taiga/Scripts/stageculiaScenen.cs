using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class stageculiaScenen : MonoBehaviour
{

	public GameObject[] GameObjectsTohidden;


	// Use this for initialization
	void Start()
	{
		//シーンが破棄されたときに呼び出されるようにする
		SceneManager.sceneUnloaded += OnSceneUnloaded;

	}

    //サブボタンが押された
    [System.Obsolete]
    public void SubButton()
	{

		//サブシーンを呼び出しているときに非表示にするゲームオブジェクト
		foreach (GameObject obj in GameObjectsTohidden)
		{
			obj.SetActive(false);
		}
		//メインシーンにサブシーンを追加表示する
		Application.LoadLevelAdditive("stage1");

	}

	private void OnSceneUnloaded(Scene current)
	{
		//シーンが破棄されたときに呼び出される
		//今回の例では、サブシーンが破棄されたら呼び出されるようになっています
		Debug.Log("OnSceneUnloaded: " + current.name);

		//本当は、どのシーンが破棄されたのか確認してから処理した方が良いかもしれない

		//ゲームオブジェクトを表示する
		foreach (GameObject obj in GameObjectsTohidden)
		{
			obj.SetActive(true);
		}
	}

}
