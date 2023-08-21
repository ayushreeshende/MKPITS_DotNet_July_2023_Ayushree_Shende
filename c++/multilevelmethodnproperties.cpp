#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		int mobno;
		void getpersondata(string name,int mobno)
{

		
	this->name=name;
		this->mobno=mobno;
}
};
class employee:public person
{
	public:
		int empno;
		int sal;
		void getempdata(int empno,int sal)
		{
			this->empno=empno;
			this->sal=sal;
		}
		void displaydata()
		{
			cout<<"emp name:"<<name<<endl;
			cout<<"emp mobno:"<<mobno<<endl;
			cout<<"emp empno:"<<empno<<endl;
			cout<<"emp sal"<<sal<<endl;
		}
};
int main()
{
	employee emp;
	cout<<"employee name,mobno,empno,sal:";
	cin>>emp.name>>emp.mobno>>emp.empno>>emp.sal;
	emp.getpersondata(emp.name,emp.mobno);
	emp.getempdata(emp.empno,emp.sal);
	emp.displaydata();
	return 0;
	
}


