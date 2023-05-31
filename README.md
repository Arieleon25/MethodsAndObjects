# MethodsAndObjects

The MethodsAndObjects project is a console application that demonstrates the usage of methods and objects in C#. It includes two classes: Person and Employee. The Person class has two properties, FirstName and LastName, as well as a void method called SayName(). The Employee class inherits from the Person class and adds an additional property called Id. The Main() method of the console app instantiates an Employee object, initializes its properties, and calls the SayName() method to display the person's full name.

# Project Description
The MethodsAndObjects project consists of two classes: Person and Employee. The classes are defined in separate files.

Person.cs
This file contains the Person class, which represents a person with a first name and a last name. The class has the following members:

Properties:

FirstName: Represents the first name of the person.

LastName: Represents the last name of the person.

Methods:

void SayName(): Writes the person's full name to the console in the format: "Name: [full name]".

Employee.cs

This file contains the Employee class, which inherits from the Person class. The Employee class adds an additional property, Id, of type int.

Program.cs

This file contains the Main() method, which serves as the entry point of the application. It instantiates an Employee object, initializes its properties with sample values, and calls the SayName() method to display the person's full name.

Instructions

Start the console application.

The program will create an instance of the Employee class.

The program will set the FirstName property of the employee to "Sample" and the LastName property to "Student".

The program will call the SayName() method on the employee object.

Observe that the person's full name is displayed on the screen in the format: "Name: [full name]".

The program will terminate.

You can rerun the program to create new instances of the Employee class and test the functionality.

# Skills Demonstrated
This project demonstrates the following skills and concepts related to methods and objects in C#:

Creating classes with properties

Defining and implementing a void method

Inheriting from a base class

Instantiating objects and initializing properties

Calling superclass methods from a subclass
