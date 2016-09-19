# Intro-To-NET-CrashCourse

This is the repository where the "hands on" portion of the "What/Why/How to .NET" crash course will live. The main branch will contain the Instructions (the README) and any other default code examples that are needed (if any). There is a branch called "Final". That is the complete example of what we are going to build. These are just a step by step guide, for the explaination and more details you have to come to the crash course. 


## Pre Reqs

Please have the following downloaded and installed before the creash course. This is not hard just time consuming (~30-60 mins) for everything to download and install. 

- Have Windows 10 installed on your computer
  - If you are on a Mac, then you have 2 options, partition your hard drive or set up a virtual machine (vm).
  - To set up a partition, look here ( https://support.apple.com/en-us/HT204990 )
  - To set up Windows 10 in a vm ( http://www.macworld.co.uk/how-to/mac-software/run-windows-10-on-your-mac-using-virtualbox-3621650 )
- Have Visual Studio Community downloaded and install
  - We will be using the Community edition ( https://www.visualstudio.com/post-download-vs/?sku=community&clcid=0x409&downloadrename=true )
  - If asked for type of environment, choose "General"


## Agenda

### Basic Winform App

#### Step 1 
- Once Visual Studio is install, open it

#### Step 2 
-  Select "New Project"
	![New Project](http://i.imgur.com/lJDdHN2.png)	
	
#### Step 3
- Select "Windows Form Application" and name it "DiceRollerSolution"
![Selecting project type](http://i.imgur.com/RHOB1aG.png)

#### Step 4
-  Open the Toolbox on the right side of the screen
![Toolbox](http://i.imgur.com/jX72nz0.png)
  
#### Step 5
- Add a "Label" to the designer by clicking and dragging
![DragonDrop](http://i.imgur.com/louy9Ac.png) 

#### Step 6
- Right-click the Label and select "Properties" 


#### Step 7
- Change the "Text" value to "My Super Cool Dice Roller". 

![Change Properties](http://i.imgur.com/CxMn8gC.png)

-SIDE NOTE: Feel free to play with the other formatting values (Color, style font, etc) 

#### Step 8 
- Add a button in the same way the label was added

#### Step 9 
- Add another Label, Change the Property called "Name" to "Output"

#### Step 10 
![Name Vs Text](http://i.imgur.com/avpTWbA.png)

#### Step 11
- Double click the button in the designer to add a button1_Click method 
![Double Click](http://i.imgur.com/eeyqnx1.png)

- Double Clicking that should bring you here
 ![Double Clicked](http://i.imgur.com/Xkrrvgw.png)



#### Step 12
- Add the random number generator code to the button1_Click method ( If you run this, you should have a six sided dice roller!)
![the first code](http://i.imgur.com/wlIdlvW.png)

#### Step 13
- Go back to the designer and add a textbox to the form (Feel free to mess around with the layout )
![enter image description here](http://i.imgur.com/3CibNt0.png) 

#### Step 14	 
- Update the button1_Click to get the value for max sides from the new text box
![enter image description here](http://i.imgur.com/3V7cDut.png)

### Class Abstraction

#### Step 1
- Right click the solutions, and select  "Add" -> "New Project" 
![new project](http://i.imgur.com/voUhnwF.png)

#### Step 2
- Add a new "Class Library", call it DiceRollerLogic
![name it](http://i.imgur.com/kxE68tj.png)

#### Step 3
-Rename "Class1" to "DiceRoller". The class code should look like this
![New Class](http://i.imgur.com/BJua8DP.png)

#### Step 4
-   Add the following code so the new class looks like this. Save your code. 
![move over the core logic](http://i.imgur.com/ZNJuoP1.png)

#### Step 5
- Back over in the solution explorer, right click the "Reference" of the original code  and a reference to the new Class Library we just made. It will be under the "Projects" tab on the left
![add it good](http://i.imgur.com/qSoXRm9.png)

![add reference](http://i.imgur.com/OnHVoDf.png)

#### Step 6
- Update the button1_Click to use the new Class library
![re-use](http://i.imgur.com/B63UZLD.png)

#### Step 7
-  Run it. It should still work as expected
![enter image description here](http://i.imgur.com/3V7cDut.png)

### BONUS: ASP.NET Web App 
#### Step 1
 - Add a new project like last but instead select "ASP.NET Web Application" and name it DiceRollerWeb
 ![new web app](http://i.imgur.com/B4FXcjb.png)
 
 
#### Step 2
- On the next screen select MVC and make sure the Host in Cloud option is checked off


#### Step 3
- Add a new Controller to the Controllers folder by right clicking the controller folder and selecting Add -> Controller. Select "MVC 5 Controller - Empty" , Call it  "DiceController"
![enter image description here](http://i.imgur.com/6Gi5REZ.png)
![enter image description here](http://i.imgur.com/xNaCvyU.png)


#### Step 4
- Open that controller and add an item to the ViewBag called Result
![enter image description here](http://i.imgur.com/hHUkzgO.png)

#### Step 5
- Right-click "return View()" and select "Add View"
![enter image description here](http://i.imgur.com/FATqAk9.png)


#### Step 6
- Leave the values as the defaults and click "Add"


#### Step 7
- Add the following HTML to the new View file
![enter image description here](http://i.imgur.com/78Z74vc.png)


#### Step 8
- Lets make sure it works. Right click the DiceRollerWeb Project and select "Select As Start Up Project"
![enter image description here](http://i.imgur.com/lVJ4NZ3.png)

#### Step 9
-  Hit the "Run button" which will not display a browser instead of "Start"
![enter image description here](http://i.imgur.com/WW2N9O3.png)

#### Step 10
- Navigate to "http://localhost:XXXXX/Dice/Index" to see your new page. The XXXXX will be the port in the url.


#### Step 11
- Stop the site and add the reference to the DiceRollerLogic like we did before, except this time we are added the reference to the DiceRollerWeb.


#### Step 12
- Update the controller to look like this
![enter image description here](http://i.imgur.com/S7KinJ2.png)

#### Step 13
- Re-run the site and go to  "http://localhost:XXXXX/Dice/Index" and it should be display a random number between 1 and 6

#### Step 14
- Now go to "http://localhost:XXXXX/Dice/Index?sides=20" and it will show a number between 1 and 20. You can change the value of sides to change the number sides are rolled


#### Step 15
- Go back to the controller and update to the following code. Change Index -> Roll and add a string to "return View("Index")
![enter image description here](http://i.imgur.com/uS89GsZ.png)

#### Step 16
- Now the url is "http://localhost:XXXXX/Dice/Roll?sides=20" 


### Future Reading and Resouces

- Meet ups
  - The Iron Yard
    - https://www.meetup.com/The-Iron-Yard-Tampa-Bay/
  - St Pete .NET
    - https://www.meetup.com/St-Pete-NET-Meetup/
    
- Sites
  - MSDN
    - https://msdn.microsoft.com/en-us/default.aspx
  - Microsft Virtual Acedemy
    - https://mva.microsoft.com/
    
- Podcasts
  - DotNet Rocks
    - https://www.dotnetrocks.com/ 
  - Scott Hansellman
    - http://www.hanselman.com/ 
    
- Books (general programing books)
  - Pragmatic Programer
  - Code Complete
