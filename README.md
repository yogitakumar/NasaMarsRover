# Mars Rover technical Challenge
The problem below requires some kind of input. You are free to implement any mechanism for feeding input into your solution (for
example, using
hard coded data within a unit test). You should provide sufficient evidence that your solution is complete by, as a minimum,
indicating that it works
correctly against the supplied test data.
We highly recommend using a unit testing framework. Even if you have not used it before, it is simple to learn and incredibly useful.
The code you write should be of production quality, and most importantly, it should be code you are proud of.
## MARS ROVERS
A squad of robotic rovers are to be landed by NASA on a plateau on Mars.
This plateau, which is curiously rectangular, must be navigated by the rovers so that their on board cameras can get a complete
view of the
surrounding terrain to send back to Earth.
A rover's position is represented by a combination of an x and y co-ordinates and a letter representing one of the four cardinal
compass points.
The plateau is divided up into a grid to simplify navigation. An example position might be 0, 0, N, which means the rover is in the
bottom left
corner and facing North.
In order to control a rover, NASA sends a simple string of letters. The possible letters are 'L', 'R' and 'M'. 'L' and 'R' makes the rover
spin 90
degrees left or right respectively, without moving from its current spot.
'M' means move forward one grid point, and maintain the same heading.
Assume that the square directly North from (x, y) is (x, y+1).
### Input:
The first line of input is the upper-right coordinates of the plateau, the lower-left coordinates are assumed to be 0,0.
The rest of the input is information pertaining to the rovers that have been deployed. Each rover has two lines of input. The first line
gives the
rover's position, and the second line is a series of instructions telling the rover how to explore the plateau.
The position is made up of two integers and a letter separated by spaces, corresponding to the x and y co-ordinates and the rover's
orientation.
Each rover will be finished sequentially, which means that the second rover won't start to move until the first one has finished
moving.
### Output:
The output for each rover should be its final co-ordinates and heading.

Test Input:
```
5 5

1 2 N

LMLMLMLMM

3 3 E

MMRMMRMRRM
```
Expected Output:
```
1 3 N

5 1 E
```
******************

After reading this problem statement I took a pencil and paper to work through the problem in a logical way.
![image](https://user-images.githubusercontent.com/61360028/119082474-1af09580-b9f6-11eb-8262-e3af2c7db319.png)

### Final Output
![image](https://user-images.githubusercontent.com/61360028/119101464-ed651580-ba10-11eb-995d-39109d1ae838.png)

### Technology used
C#

NUnit

### How to install and use
1. Clone the repository
```
git clone https://github.com/yogitakumar/NasaMarsRover.git
```

2. Navigate through project, and open NasaMarsRover.sln
 ![image](https://user-images.githubusercontent.com/61360028/119126181-9e2bde80-ba2a-11eb-92b2-68659b0509fb.png)

3. Build Project from Build Menu
4. Run your project
5. To run test cases 
![image](https://user-images.githubusercontent.com/61360028/119126611-24e0bb80-ba2b-11eb-9e12-12002f15af48.png)

### Test Driven Development
I used TDD approch while working with this problem, Test Driven Development (TDD) is software development approach in which test cases are developed to specify and validate what the code will do. In simple terms, test cases for each functionality are created and tested first and if the test fails then the new code is written in order to pass the test and making code simple and bug-free.

Here I write some tests to check Plateau bound, plateau upperbound, lowerbound, roverlanding, commands, input.

TDD approch is
1. Write fail test
2. Make test pass
3. Refactor code

🎉🎊🎉🥳
####  And
## Rover moves successfully on plateau of Mars
