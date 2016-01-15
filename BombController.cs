using UnityEngine;
using System.Collections;
//
public enum BombStatus
{
	NONE = -1,// 状態無し
	SET = 0,// 生成時
	WAIT,// 待機時
	BROKEN,// 被破壊時
	EXPLODE,// 爆発時
}

public class BombController : MonoBehaviour
{
	// キャッシュ
	[SerializeField]
	BombStatus bombSts = BombStatus.NONE;
	// --------------------------------------------
	// フラグ
	// --------------------------------------------

	// 被タッチ時の処理
	public bool TouchFunction()
	{
		Debug.Log(this.gameObject.name + ": タッチされました。");
		return true;
	}
	// 再・被タッチ時の処理
	public bool ReTouchFunction()
	{
		Debug.Log(this.gameObject.name + ": 再度タッチされました。");
		return true;
	}
}