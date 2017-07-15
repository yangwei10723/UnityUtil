using System;
using UnityEngine;

public class XMonoBehaviourCache : MonoBehaviour
{
    private bool _cachedName;
    private string _goName;
    public string goName
    {
        get
        {
            if (!_cachedName)
            {
                _goName = gameObject.name;
                _cachedName = true;
            }
            return _goName;
        }
        set
        {
            _goName = value;
            gameObject.name = value;
            _cachedName = true;
        }
    }

    private bool _cachedTag;
    private string _goTag;
    public string goTag
    {
        get
        {
            if (!_cachedTag)
            {
                _goTag = gameObject.tag;
                _cachedTag = true;
            }
            return _goTag;
        }
        set
        {
            _goTag = value;
            gameObject.tag = value;
            _cachedTag = true;
        }
    }
}

