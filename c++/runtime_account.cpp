#include<iostream>
using namespace std;
class account
{
	public:
		int actno;
		int bal;
		virtual void deposit(int amt)
		{
			cout<<"hello from account deposit"<<endl;
		}
};
class saving:public account
{
	public:
		void deposit(int amt)
		{
			int interest=500;
			bal=bal+amt+interest;
			cout<<"bal with interest is"<<bal<<endl;
		}
};
class current:public account
{
	public:
void deposit(int amt)
{
	bal=bal+amt;
	cout<<"bal without int"<<bal<<endl;
		}		
};
int main()
{
	account *A;
	saving s;
	current c;
	A=&s;
	A->actno=123;
	A->bal=1000;
	A->deposit(500);
	A=&c;
	A->actno=234;
	A->bal=4000;
	A->deposit(500);
	return 0;
	
}


