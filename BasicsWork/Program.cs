// Primitive Types Task 1

int intTest = 5;
double doubTest = 6.66;
string strTest = "Bread";
bool boolTest = false;

Console.WriteLine("The Integer saved is: "+ intTest );
Console.WriteLine("The Double saved is: "+ doubTest );
Console.WriteLine("The String saved is: "+ strTest );
Console.WriteLine("The Boolean saved is: "+ boolTest );

// Primitive Types Task 2

/* When converting integer to decimal the information will be stored fully however information 
will be lost when a decimal is converted to integer (That being the fractional part of the number)*/

int numToConvert = 10;
double numConverted = Convert.ToDouble(numToConvert);

Console.WriteLine("The Integer that was converted to a Double: "+ numConverted);

/* Char data type research: The char data type is used when you need to store a
single character (a-z,1-9,symbols, etc..) instead of an array of characters like with a string. 
Chars are used instead of a string (of a single character) to save on memory as well. */


// C# Variables Task 1

// camelCase
string studentName1 = "Bread";
double gpaStudent1 = 3.98;
string student1FavoriteSubject = "Chemistry";

// Underscore, Kebab
string student_name2 = "Donut";
double gpa_student_2 = 1.87;
string studnet2_favorite_subject = "Home";

// C# Variables Task 2
// Area of rectangle = h x w

/* When declaring variables using const instead of a regular declaration 
the declared variable cannot be modified. These variables can still be used to do math,
however you must keep in mind that they will not change. A const variable must also always
be assigned a value that is not null.*/

const double width = 5.5;
double height = 3.2;

double answer = 0;
const double constAnswer = 0;

answer = width * height; 

// The expression below is incorrect because constAnswer is a const variable
//constAnswer = width * height;

Console.WriteLine("The Area of the Rectangle with heigth (3.2) and width (5.5) is: "+answer);
//Console.WriteLine("The Area of the Rectangle with heigth (3.2) and width (5.5) is: "+constAnswer);


// C# Control Flow

// Get time of day in hours and store it
DateTime currentTime = new DateTime(DateTime.Now.TimeOfDay.Ticks);
int timeInHours = Convert.ToInt32(currentTime.ToString("HH"));
     

if(timeInHours >= 11 && timeInHours <= 14)
{
    Console.WriteLine("Time for Lunch!");
}

Console.WriteLine(timeInHours);




