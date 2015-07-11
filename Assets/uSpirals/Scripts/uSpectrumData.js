// 	Copyright 2012 Unluck Software, Egil Andre Larsen 
//	http://www.chemicalbliss.com
//
//	This script is just a demonstration on how the spiral generator can be used with spectrum data, contact me if you need a more up to date version.

var Audio : Transform;
var spiral : Transform;
var growSpeed : float = 10.0;
var useFrequency : boolean = true;
var growFrequency : float = 5.0;  
var channel : int;
var numSamples : int;
var freq : int;
var number = new Array ();
     
private var multiBuffer:float;
private var heightBuffer:float;
private var depthBuffer:float;

function Start () {
	multiBuffer = spiral.GetComponent(unluckSpiral).sineGrowMultiplier;
	heightBuffer = spiral.GetComponent(unluckSpiral).sineHeightFrequency;
	depthBuffer = spiral.GetComponent(unluckSpiral).sineDepthFrequency;
}
   
    
function Update () {    
	var number = Audio.GetComponent(AudioListener).GetSpectrumData(numSamples, channel, FFTWindow.Rectangular);
	var dif = multiBuffer*number[freq]*10 - spiral.GetComponent(unluckSpiral).sineGrowMultiplier;
	spiral.GetComponent(unluckSpiral).sineGrowMultiplier += dif*Time.deltaTime*growSpeed;
	if(useFrequency){
		dif = heightBuffer*number[freq]*growFrequency - spiral.GetComponent(unluckSpiral).sineHeightFrequency;
		spiral.GetComponent(unluckSpiral).sineHeightFrequency += dif*Time.deltaTime*growSpeed;
		dif = depthBuffer*number[freq]*growFrequency - spiral.GetComponent(unluckSpiral).sineDepthFrequency;
		spiral.GetComponent(unluckSpiral).sineDepthFrequency += dif*Time.deltaTime*growSpeed;
	}
}