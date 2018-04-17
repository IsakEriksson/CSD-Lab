Block 1 supplementation:

Feedback
	"Please eliminate usage of static keyword."
Action
	Static keywords eliminated.
	Class IDIndexer created. Objects of this class handle the logic of indexing elements.

Block 1 submission:

(1) Natural language high-level description
	This solution displays a back-end solution for a contact information platform (in its early stages).
	
	By using the program a user is able to create Person objects, virtually storing the attributes first name,
	last name and phone number. Every Person created is assigned an identifier as well.
	
	Persons are then stored in a PersonStorage, which contains basic CRUD functionality. Furthermore, this storage
	can be searched using a PersonSearcher (which is a subclass of Searcher) and its various functions.

(2) List of dependencies
	- .NET Framwork

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