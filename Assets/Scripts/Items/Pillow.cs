using UnityEngine;

public class Pillow : Items
{ private bool _isBye = false;
    public override void OnMouseDown()
    {
        base.OnMouseDown();
        poly.enabled =true;
        if(_isBye == true)
        _anim.SetTrigger("Bye");
        
        _isBye = true;
    }
}