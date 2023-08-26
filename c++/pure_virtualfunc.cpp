#include<iostream>
using namespace std;
class account
{
	public:
		int actno;
		int bal;
	virtual	void deposit(int amt)=0;
	
};
class saving:public account
{
	public:
		void deposit(int amt)
		{
			int interest=500;
			bal=bal+amt+interest;
			cout<<"bal with interest"<<bal<<endl;
		}
};
class current:public account
{
	public:
		void deposit(int amt)
		{
			bal=bal+amt;
			cout<<"bal without interest"<<bal<<endl;
		}
};
int main()
{
	account *A;
	saving s;
	current C;
	A=&s;
	A->actno=123;
	A->bal=3000;
	A->deposit(2000);
	A=&C;
	A->actno=333;
	A->bal=2000;
	A->deposit(500);
	return 0;
}
