# Intro-To-NET-CrashCourse

This is the repository where the "hands on" portion of the "What/Why/How to .NET" crash course will live. The main branch will contain the Instructions (the README) and any other default code examples that are needed (if any). There is a branch called "Final". That is the complete example of what we are going to build


### Pre Reqs

Please have the following downloaded and installed before the creash course. This is not hard just time consuming (~30-60 mins) for everything to download and install. 

- Have Windows 10 installed on your computer
  - If you are on a Mac, then you have 2 options, partition your hard drive or set up a virtual machine (vm).
  - To set up a partition, look here ( https://support.apple.com/en-us/HT204990 )
  - To set up Windows 10 in a vm ( http://www.macworld.co.uk/how-to/mac-software/run-windows-10-on-your-mac-using-virtualbox-3621650 )
- Have Visual Studio Community downloaded and install
  - We will be using the Community edition ( https://www.visualstudio.com/post-download-vs/?sku=community&clcid=0x409&downloadrename=true )
  - If asked for type of environment, choose "General"


### Agenda

#### Basic Winform App
	1. Once Visual Studio is install, open it
	2. Select "New Project"
	
	 ![New Project](http://i.imgur.com/lJDdHN2.png)
	
	3. Select "Windows Form Application"
		- Name it "DiceRollerSolution" 
	4.Open the Toolbox on the right side of the screen
	5. Add a "Label" to the designer by clicking and dragging
	6. Right-click the Label and select "Properties"
	7. Change the "Text" value to "My Super Cool Dice Roller"
	8. Feel free to play with the other formatting values (Color, style font, etc) 
	9. Add a button in the same way the label was added
	10. Add another Label, Change the Property called "Name" to "Output"
	11. Double click the button in the designer to add a button1_Click method (this should take you the code behind
	12. Add the random number generator code to the button1_Click method ( If you run this, you should have a six sided dice roller!)
	13. Go back to the designer and add a textbox to the form (Feel free to mess around with the layout )
	14. Update the button1_Click to get the value for max sides from the new text box

#### Class Abstraction

#### BONUS: ASP.NET Web App 



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

