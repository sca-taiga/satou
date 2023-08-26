using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SelectCharacter
{
    [CreateAssetMenu(fileName = "MyGameManagerData", menuName = "MyGameManagerData")]
    public class MyGameManagerData : ScriptableObject
    {
        //�@���̃V�[����
        [SerializeField]
        private string StageSlect;
        //�@�g�p����L�����N�^�[�v���n�u
        [SerializeField]
        private GameObject character;
        //�@�f�[�^�̏�����
        private void OnEnable()
        {
            //�@�^�C�g���V�[���̎��������Z�b�g
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