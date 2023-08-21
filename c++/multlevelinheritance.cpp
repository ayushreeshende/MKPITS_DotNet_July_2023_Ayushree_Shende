#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		int mobno;
		
};
class employee:public person
{
	public:
	int empno;
	int sal;
};
class parttimeemployee:public employee
{
	public:
		int noofhours;
};
int main()
{
employee e1;
e1.name="khushi";
e1.mobno=34566;
e1.empno=234;
e1.sal=4000;
cout<<"emp detail"<<endl;
cout<<e1.name<<e1.mobno<<e1.empno<<e1.sal<<endl;

parttimeemployee p1;
p1.name="manish";
p1.mobno=234;
p1.empno=3456;
p1.sal=8000;
p1.noofhours=5;
cout<<"parttime employee detail"<<endl;
cout<<p1.name<<p1.mobno<<p1.empno<<p1.sal<<p1.noof
hours<<endl;
return 0;
}
