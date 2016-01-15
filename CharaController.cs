using UnityEngine;
using System.Collections;
//
public enum ActionStatus
{
	NONE = -1,
	STAY,
	WALK,
	RUN,
}

public class CharaController : MonoBehaviour
{
	[System.Serializable]
	public class CharaStatus
	{
		public string name = "";// キャラの名前
		public int health = 0;// HP
		public int maxHealth = 3;// MAXHP
	}

	// キャッシュ
	[SerializeField]
	protected ActionStatus actionSts = ActionStatus.NONE;
	// --------------------------------------------
	// フラグ
	protected bool isControllable = false;// 操作可能かどうか
	protected bool ChangeControllable(bool which){return isControllable = which;}
	// --------------------------------------------

	void Update()
	{
	}
}