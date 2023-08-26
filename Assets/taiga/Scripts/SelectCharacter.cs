using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SelectCharacter
{
    [CreateAssetMenu(fileName = "MyGameManagerData", menuName = "MyGameManagerData")]
    public class MyGameManagerData : ScriptableObject
    {
        //　次のシーン名
        [SerializeField]
        private string StageSlect;
        //　使用するキャラクタープレハブ
        [SerializeField]
        private GameObject character;
        //　データの初期化
        private void OnEnable()
        {
            //　タイトルシーンの時だけリセット
            if (SceneManager.GetActiveScene().name == "SelectCharacterTitle")
            {
                StageSlect = "";
                character = null;
            }
        }

        public void SetNextSceneName(string nextSceneName)
        {
            this.StageSlect = nextSceneName;
        }

        public string GetNextSceneName()
        {
            return StageSlect;
        }

        public void SetCharacter(GameObject character)
        {
            this.character = character;
        }

        public GameObject GetCharacter()
        {
            return character;
        }
    }
}