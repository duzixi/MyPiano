Unluck Spiral Generator

Features

	• Customizable Spiral LineRenderer Script
	• Multi LineRenderer Script for using several spirals in one beam, with rotation offset option
	• Full Screen possibilities by positioning the spiral close to the camera, great for menus and effects
	• Scriptable parameters, making it possible to change appearance of spiral in run-time
	• Offset and scale option for materials, easily texture line and offset over time (animated flow effects)
	• Perling Noise distortion option
	• Well commented and easily understandable code
	• 14x Sample scenes
	• 26x Spiral prefabs
	• 9x Spiral Materials


Notes

  •For a smooth spiral, keep depht/frequency/speed the same as height/frequency/speed
  •Performance notes:
		Try to keep all unused variables to 0
		Use rotate instead of Sine Speeds if possible
		"runOnceThenDisable" turns off the spiral generation, big performance gain (rotation and material animation still works)
	•Creating a new spiral:
		Use an existing prefab
		Press play
		Change the variables while in play mode (remember to turn off "runOnceThenDisable" before pressing play)
		When the spiral looks like it is suppose to, drag it from Hierarchy to Project folder
		Drag the prefab from Project to Hierarcy
		Remove lineRenderer component from "Beam" child (optional but recommended)
		Assign start and end targets
		Delete the old spiral from Hierarcy if needed
	•Creating a multi spiral:
		Create or use a existing spiral prefab
		Use a premade multiSpiral prefab or attach the multiSpiral script to a empty gameObject
		Set how many spirals the multiSpiral should spawn in the "spiralWithRotationArray" 
		Assign the spirals to each index of the array (if using the same spiral for several, set lenght to 1 first and assign the spiral then set to desired lenght)

More information on each variable is written as comments in the "unluckSpiral.js" script



Feel free to contact me trough my website at http://www.chemicalbliss.com/

Thanks for purchasing this software
Have fun with Unity!