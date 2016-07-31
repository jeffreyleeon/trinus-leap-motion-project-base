using UnityEngine;
using System.Collections;

public class HandStore : Singleton<HandStore> {
	protected HandStore () {} // guarantee this will be always a singleton only - can't use the constructor!

	private HandModel[] _handModels = null;

	public HandModel[] GetHandModels () {
		return _handModels;	
	}

	public void SetHandModels (HandModel[] handModels) {
		_handModels = handModels;
	}

	public bool IsHandAppearing () {
		return _handModels != null && _handModels.Length > 0;
	}
}
