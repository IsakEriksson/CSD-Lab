Block 2 submission:
(1) Natural language high-level description
	The description of the program highly remains like in submission 1.

	The solution is still meant to be implemented as a back-end solution eventually, although it is yet a
	console application.

	New for this submission is the ability to store organizations in the same way persons were previously
	stored. All of the attributes of a person or organization are searchable. This means a phonebook can now
	be built, storing both persons and organizations.

	The program now also contains a testing suite.

(2) List of dependencies
	- .NET Framework

(3) Installation instructions
	The program does not need to be installed - simply run the Program.cs file.
	By default the program creates certain objects and assign them values. This can be changed by emptying
	the contents of static void Main(string[] args) in class Program.

(4) Testing instructions
	1. Open the solution in the IDE Visual Studio on Windows (the testing suite does not work on Mac).
	2. Open Test Explorer by going to Test/Windows/Test Explorer.
	3. To run all tests, click the blue text saying "Run All".
	4. To run a specific test, right-click the test and choose "Run Selected Tests".

	Note that the tests are designed to test the program in its entirety. If something is not tested explicitly
	(like the first search methods of the OrganizationSearcher class) it is because the same logic is tested
	somewhere else (in this case in the PersonSearcher class).

(5) Usage instructions
	The usage instructions remain the same as of submission, with the above instructions for testing the application.

-----

Block 1 supplementation:

Feedback
	"Please eliminate usage of static keyword."
Action
	Static keywords eliminated.
	Class IDIndexer created. Objects of this class handle the logic of indexing elements.

-----

Block 1 submission:

(1) Natural language high-level description
	This solution displays a back-end solution for a contact information platform (in its early stages).
	
	By using the program a user is able to create Person objects, virtually storing the attributes first name,
	last name and phone number. Every Person created is assigned an identifier as well.
	
	Persons are then stored in a PersonStorage, which contains basic CRUD functionality. Furthermore, this storage
	can be searched using a PersonSearcher (which is a subclass of Searcher) and its various functions.

(2) List of dependencies
	- .NET Framework

(3) Installation instructions
	The program does not need to be installed - simply run the Program.cs file.
	By default the program creates certain objects and assign them values. This can be changed by emptying
	the contents of static void Main(string[] args) in class Program.

(4) Testing instructions
	As of submission for Block 1 no test suite is available.

(5) Usage instructions
	The program is meant to be a backend application. It is best used by involving it in a larger application,
	utlizing its scalability. It can then provide objects and infrastructure for contact information.

	The program could also be used as a console application, although this funcitonality is mainly implemented
	for testing purposes.