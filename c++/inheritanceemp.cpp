#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		string city;
};
class employee:public person
{
	public:
		string salary;
	string designation;
	int empno;
	
};
int main()
{
	int name,city,salary,designation,empno;
employee e1;
cout<<"name,city,salary,designation,empno";
cin>>e1.name>>e1.city>>e1.salary>>e1.designation>>e1.empno;
cout<<"name"<<e1.name<<endl;
cout<<"city"<<e1.city<<endl;
cout<<"salary"<<e1.salary<<endl;
cout<<"designation"<<e1.designation<<endl;
cout<<"empno"<<e1.empno<<endl;
return 0;
}
