#include<iostream>
using namespace std;
class person
{
	public:
	string name;
	string city;
};
class student:public person
{
	public:
	int rollno;
	int marks;
	
};
int main()
{
	student s1;
	s1.name="ayushree";
	s1.city="nagpur";
	s1.rollno=123;
	s1.marks=68;
	cout<<s1.name<<endl<<s1.city<<endl<<s1.rollno<<endl<<s1.marks<<endl;
	return 0;
}

