#include<iostream>
using  namespace std;
class employee
{
	public:
		int empno;
		string empname;
		employee()
		{
			empno=123;
			empname="khush";
			
		}
		void display()
		{
			cout<<"empno"<<empno<<endl;
			cout<<"empname"<<empname<<endl;
			
		}
};
int main()
{
	employee emp1;
	emp1.display();
	return 0;
}
