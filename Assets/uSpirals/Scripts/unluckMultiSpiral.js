// 	Copyright 2012 Unluck Software, Egil Andre Larsen 
//	http://www.chemicalbliss.com
var targetStart:Transform;
var targetEnd:Transform;
var rotationOffset:float;
var autoCalculateCircle:boolean;
var startEffects:int = 1;
var spiralWithRotationArray:GameObject[];
var spiralArray:GameObject[];

function Start () {
	if(autoCalculateCircle)
	rotationOffset = 360/spiralWithRotationArray.LongLength;
	for(var i :int = 0; i < spiralWithRotationArray.LongLength; i++){
		var newSpiral:GameObject = Instantiate(spiralWithRotationArray[i]);
		var spiralScript:unluckSpiral = newSpiral.transform.GetComponent("unluckSpiral");
		spiralScript.rotationOffset = rotationOffset*i;
		spiralScript.targetStart = targetStart;
		spiralScript.targetEnd = targetEnd;
		if(i >= startEffects)
		Destroy(newSpiral.transform.FindChild("Start").gameObject);
	}
}