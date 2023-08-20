#include<iostream>
using namespace std;
class student
{
public:
string name;	
int clas;
int rollno;

void getstudent()
{
cout<<"enter student name,rollno,class:";
cin>>name>>rollno>>clas;
}
void displaystudent()
{
	cout<<"student name:"<<name<<endl;
	cout<<"rollno:"<<rollno<<endl;
	cout<<"class:"<<clas<<endl;
}
float calculategrade()
{
float m1,m2,m3,per,total;
cout<<"enter 3 subject marks:";
cin>>m1>>m2>>m3;
total=m1+m2+m3;
cout<<"total marks:"<<total<<endl;
per=(m1+m2+m3)/300*100;
cout<<"percentage:"<<per<<endl;
if(per>=75)
{
	cout<<"grade is distinction"<<endl;
}
else if(per>=60)
{
	cout<<"grade is first"<<endl;
	
}
else if(per>=40)
{
	cout<<"grade is second"<<endl;
	
}
else
{
	cout<<"fail"<<endl;
}
}
};

int main()
{
	student s1;
	s1.getstudent();
	s1.displaystudent();
	s1.calculategrade();
	return 0;
}



