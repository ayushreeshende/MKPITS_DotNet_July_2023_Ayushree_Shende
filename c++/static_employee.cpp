#include<iostream>
using namespace std;
class employee
{
	public:
	int empno;
	string empname;
	static string compname;
	employee(int empno,string empname)
	{
		this->empno=empno;
		this->empname=empname;
	}
	void display()
	{
		cout<<"empno"<<empno<<endl;
		cout<<"empname"<<empname<<endl;
		cout<<"compname"<<compname<<endl;
		
	}
};
string employee::compname="tecnomine";
int main()
{
	employee e1=employee(12,"ayush");
	employee e2=employee(34,"arpit");
	e1.display();
	e2.display();
	return 0;
}
