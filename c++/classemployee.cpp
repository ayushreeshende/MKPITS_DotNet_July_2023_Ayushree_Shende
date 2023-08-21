#include<iostream>
using namespace std;
class employee
{
	public:
		int num;
		string name;
		string desig;
		int sal;
		void data()
		{
			cout<<"empnum"<<"empname"<<"empdesig"<<"empsal";
			cin>>num>>name>>desig>>sal;
		}
		void display()
		{
			cout<<"empnum:"<<num<<endl;
			cout<<"empname:"<<name<<endl;
			cout<<"empdesig:"<<desig<<endl;
			cout<<"empsal:"<<sal<<endl;
		}
};
int main()
{
	employee emp1,emp2;
	cout<<"employee1"<<endl;
	emp1.data();
	emp1.display();
	cout<<"employee2"<<endl;
	emp2.data();
	emp2.display();
	return 0;
}

