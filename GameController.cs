using UnityEngine;
using System.Collections;
// どんとですとろい を付ける
public enum GameStatus
{
	NONE = -1,// 状態なし
	PLAYING = 0,// ゲーム中
	PAUSE,// ポーズ中
	GAMEOVER,// ゲームオーバー
}

public class GameController : MonoBehaviour
{
	// キャッシュ
	GameStatus gameSts = GameStatus.NONE;// ゲーム状態のキャッシュ
	// --------------------------------------------
	//フラグ
	// --------------------------------------------

	void Awake()
	{
		//
	}

	void Start()
	{
		//
	}
}