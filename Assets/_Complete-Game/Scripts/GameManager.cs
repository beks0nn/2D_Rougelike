using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

namespace Completed
{
	public class GameManager : MonoBehaviour
	{

		public static GameManager instance = null;
		private BoardManager boardScript;	
		private int level = 3;	
		
		//Awake is always called before any Start functions
		void Awake()
		{
            if (instance == null)
                instance = this;
            else if (instance != this)
                Destroy(gameObject);	
			
			DontDestroyOnLoad(gameObject);
			boardScript = GetComponent<BoardManager>();
			InitGame();
		}

		//Initializes the game for each level.
		void InitGame()
		{
			boardScript.SetupScene(level);	
		}
		
		//Update is called every frame.
		void Update()
		{
		}
	}
}

