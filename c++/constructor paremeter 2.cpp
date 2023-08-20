#include<iostream>
using namespace std;
class employee
{
	public:
		int empno;
		string empname;
		employee(int eno,string en)
		{
			empno=eno;
			empname=en;
			
		}
		void display()
		{
			cout<<"enter employee no"<<empno<<endl;
			cout<<"enter employee name"<<empname<<endl;
			
		}
};
int main()
{
	int eno;
	string en;
	cout<<"enter employee no and name";
	cin>>eno>>en;
	employee emp1(eno,en);
	emp1.display();
	return 0;
	
	}

