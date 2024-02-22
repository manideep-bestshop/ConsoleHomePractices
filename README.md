OOPS
----
Object Oriented Programming Systems(oops),which is used to design program usings Classes and Objects.

Why OOPS Conecpt?
-----------------
By using oops conecpet we acn get following features

1.Data is restricted
2.accurate code reusability
3.equal priority for Data and Procedure
4.functions are used for accessing and then for calculations

Software provided with OOPS:
----------------------------
c#.net,VB.net,C++,Java,ADA,SIMULA,effel...etc

feaures of OOPS:
----------------
1.data hiding
2.data abstarction
3.data encapsulation
4.inheritance
5.polymorphism

Components of OOPS: oops is dependent on 2 components often called building blocks
-------------------
1.Class
2.Object
Components of OOPS: oops is dependent on 2 components often called building blocks
-------------------
1.Class
2.Object

Class:
------
class is defined as "Collection of fields(Data Members)+methods(Member functions)+Properties"

1.we can not create class local to methods
2.class does not allow to write executable statements like i/p o/p statements ,if conditions,loops etc..
3. members created in class can be provided with 5 access modifiers
a)Private (default)
b)Public  (deafault)
c)Protected
d)Internal
e)Protected Internal

Object:
-------
1.It is defined as instance of a class 
2.it is used to access memebers of a class (depends on access modifier)
3.It access members through access operator (dot operator)

syntax: classname objectname = new classname();
          |          |          |       |
		datatype    variable   dynamic  constructor
                               memory
                               allocation
4.minimum one object is must
5.more than one object can create to a single class but always with unique name 

Points To be remembered to access Class
---------------------------------------
1.By deafault members of a class are Private.
2.members created with public access modifier can be access through out the program i.e within class and outside the class.
(within class directly and outside the class through object)
3.members created with private access modifier works only within the class.
4.when a class consists of private members it is must to have atleast one public method.
5.members with protected access modifier works similar to private access modifier difference will notice in inheritance

6.Data hiding:
-------------- 
data stored in private members cant be viewd out side of the class is called data hiding.

7.Data Abstraction:
-------------------
It is a process ofextracting relevant information while ignoring irrelevant information

8.Data encapsulation:
---------------------
grouping data members(fields) and member funcations(methods) into single unit i.e Object


call by Value and call by reference:
------------------------------------
Call by value:
--------------
1.when a message is pass to class ,along with that values can be sent as Parameters 
2.Sending Parameters and receiving arguments should be same in number and should same in type
3.sending parameters are often called as "original/actual parameters" where as receiving arguments are often called as "Formal arguments".
4. as sending type are of value type so receiving arguments should be of value type variables.
5.formal arguments in methods acts like variable ogf that method.
6.if any changes are made to local variables of receiving args,it will not reflects on orinal parameters so itb is called
"call by value"

this key word/object:
---------------------
- It is used to differentiate between local variables and fields when they are with same name
- It will access field members through access operator (dot operator).

method returning value:
-----------------------
1.A method created in class may or may not return value.
2.if it is returning value,return type should be specified based on the value which is being returned from the method.
3.the max of only one value can be return from a method.
4.return can return value through constant/local variable/field/Mathematical expression.

call by value:
--------------
1.only values are copied,no modifications reflect in orinal values

call by ref:
------------
1.references are copied so values can accessed,modifications are reflected

Call by out:
------------
1.references are copied so values can not accessed,modifications are reflected

namespace CallByValueRefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;                        // actual or original parameters
            x = 10;
            y = 20;
            CByV(x,y);                     //call by value
            Console.WriteLine("After CallByValue "+x+","+y);    // modifications in a and b are not reflecting here

            CByR(ref x,ref y);  //call by Ref
            Console.WriteLine("After CallByRef " + x + "," + y); // modifications in a and b are reflecting here

            x = 10;
            y = 20;
            int z = -6;
            CByO(ref x,ref y,out z);
            Console.WriteLine("Value of Z= " + z);

        }
        public static void CByV(int a,int b)  //recieving arguments/ formal arguemnts
        {
            Console.WriteLine(a + ", " + b);
            a = 100;
            b = 200;    
        }

        public static void CByR(ref int a,ref int b)  //recieving arguments/ formal arguemnts
        {
            Console.WriteLine(a + ", " + b);
            a = 100;
            b = 200;
        }
        public static void CByO(ref int a,ref int b,out int c)   //recieving arguments/ formal arguemnts
        {
            Console.WriteLine(a+","+b);
           // Console.WriteLine(c); we can not acess values
            c = a + b;
            Console.WriteLine(c);
        }
    }
}
 
Methods in c# are classified into following types
-------------------------------------------------
1.method without arguments
2.method with args
3.method with return value
4.method with with no return value
5.method with arguments and default value

Object As Array:
----------------
1.Object created for a class can be of array ,which allow to store data with multiple values
2.it gets accessed based on index positions

syn: memory for object as array
     class_name[] obj=new class_name[size];
	 
syn: memory for memebers
     obj[inex]=new class_name();

	  Member Class:
-------------
1. memeber class which is created within other class is called Member class.
2.It is also called as Nested class, Container class, composition and synonymous class.
3.it creates "Has-A" relationship between class

Ex: Car has a sterio

4.A class (type) created to namespace can be provided with only 2 access modifiers public and internal 
default is internal
5.members in class can be create with any access modifier

Method Over Loading:
--------------------
1.two or more methods having same name but differs at count of parameters or types of parameters or kind of parameters
2.it is a concept of polymorphism

poly-many
morphism-forms
i.e. many forms

3.the link between message passing and method body is created at compilation of program.Hence it is called compile time 
polymorphism/early binding/static binding
4.method not overloaded when arguments with different names,different retun types,different codes,different access modifiers

Examples:
---------
overloaded:
public void show(int p1,int p2){}
public void show(int p1,out int p2){}

Overloaded:
public void show(int p1,int p2){}
public void show(int p1,ref int p2){}

not overloaded because ref works like out:
public void show(int p1,int p2){}
public void show(int p1,out int p2){}
public void show(int p1,ref int p2){}

Categories of Fields:
--------------------
1.Instance Fileds
2.Static field members
3.Const field members
4.Raed only filed members
5.Static Read only field members
Constructors and Destructors:
----------------------------
Constructors:
-------------
these are special methods of class,which are used to construct the data (storing data into fields) at the time when instance is created

types:
-----
1.Instance member constructor-Dependent on instance
2.static constructor-Independent of instance

implementation of instance member constructor
---------------------------------------------
1.Parameterless constructor / default constructor

access_modifier classname()
{
  statements;
}

2.Parameterized constructor

access_modifier classname(arguments)
{
  statements;
}

3.copy constructor

access_modifier classname(class_name objectname)
{
  statements;
}

Characteristics of construct:
-----------------------------
1.class name and constructor must be same
2.no return type (default return type is void)
3.no return value
4.implicity gets called

Destructors:
 ------------
 -class name and destructor name should be same and it should be proceeded by tide symbol.(~)
 -A destructor is used to release the resources that an object is holdong.when an object is raedy to destroyed  "finalize()" method
 is called on that object.
 -constructor in c# can not have any access modifier and it cant be over loaded a well.
 Static Members:
---------------
1.constructor
2.fields
3.methods
4.class
5.object

Static constructor:
-------------------
1.this constructor is created with "Static" keyword
2.it is used to Initialise static fields of a class
3.it is executed by CLR when class is loaded
4.it is executed only for once through out the life of program
5.it cant be overloaded
6.difference between constructor and static constructor is--
"instance member will be executed for each instance craeted for a class 
where as static constructor will be executed only for once".
7.in a class if there is main method and static constructor ClR first execute static constructor then main method
static fields:
--------------
1.a field in a class created with static keyword.
2.memory to static field is allocated only once.
3.it is accessible outsidethe class through class name.

static method:
--------------
1.craeted with static keyword
2.message to this method is passed from outside the class through class name(depend on access modifier)

static blocks can not allow to access non static members where as non static blocks will allow to access both 
static and static members..

-> Both static and no static members
Inheritance:
------------
1. It is a process of creating new class from existing class referes to inheritance.
2.existing class is called Base class,parent class, super class
  new class is called derived class ,child class,sub class
3.it is the one of the main features of oops which provides accurate code reusability
  i.e. once class gets compiled it can be used for any no. of times
4.the other name of Inheritance is Derivation
5.the relationship which is created b/w classes is , "IS-A" relationship

it maintains Parent Child relationship

"IS-A" Relationship  

example:
--------
Car is-a vehicle
Faculty is-a person
chair is-a furniture

chair is-a table (No Inheritance)
daughter is-a mother(no inheritance)
son is-a father(no inheritance)

father is-a son(inheritance)
mother is-a daughter(inheritance)

-Inheritance in real time is used in 2 prospectives

1.Extendibility
---------------
an existing app can be added with few instructions that leads to new features into an app

ex: a program-developed-standard calculator-can be added with few lines of code- 
to develop- scientific calculator

2.Generalization:
-----------------
it is a process of Deriving multile child classes from a single base class

ex:                    vehicle(engine,fuel)--base/parent
        car(4 wheeler,4 seater)--derived/child    scooter(2 wheeler,2 seater)--derived/child

Inheritance in c# implemented in different ways:
1. single Inheritance
2.multi level inheritance
3.hierarchical inheritance
- in c# only one class can be extended to other class

1)Single Inheritance:
---------------------
   it is a process of creating only 1 derived class from a base class.
   
   baseclass   access    derivedclass
         A  -------------> B
      
points to be remembered:
------------------------
1.every class created in c# are child class of system.object class
2.when we create instance for derived momoery allocated for both derived and base class
3. when instance of base class created,memory allocates to members of its class only.
method shadowing
----------------
4.when method created in base clss anf if the same method is created in derived class having
 same name,same count,same type and same kind of parameters then its called method shadowing ,
 where as for onlysame name is enough then it is called Field Shadowing.
 same name with different count type and king is called method over loading
 
new key word:
-------------
 it referes two tasks
 1.used for dynamic memory allocation
 2.used to avoid warning from the member of derived class when method/field shadowing takes place
 
base key word:
--------------
it can be used with methods fields and constructors
   it is used to differentiate when members are with same names in base and derived class.
   
Static Binding and Dynamic Binding:
-----------------------------------

Static Binding/Early Binding/ CTE Binding:
------------------------------------------
Binding means mapping one thing to another

-->In static binding, function calls are resolved at compile time by the compiler itself.
   The binding of all the static and private functions/methods of a class happens at compile time.

Dynamic Binding/Late Binding/ Run time Binding:
-----------------------------------------------

-->In dynamic binding, function calls are resolved at run time. 
   Function overriding in OOP is possible due to dynamic/late binding. 
   
note2:
------             scenario-1              scenario-2              scenario-3
In parent           virtual                  virual                 -----
In Clid             Override                 -----                  Override
execution           Override                 virtual                 CTE
Abstract class and Abstract Method:
----------------------------------
Abstraction is showing neccessory information while ignoring the background details

1.Abstract method is a method in which declaration is provided but not impmentation(method declaration is caaled method signature)
2.A class with one or more methods declared as abstract that class should also be declared 
as abstract and such a class cant be instantiated because it is behaviour is incomplete.
3. a class which is not abstract is called as "Concrete class"
