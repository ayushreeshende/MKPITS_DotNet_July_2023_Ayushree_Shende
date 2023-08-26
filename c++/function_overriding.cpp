#include<iostream>
using namespace std;
class account
{
	public:
		int actno;
		int bal;
		void deposit(int amt)
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
	saving S;
	current C;
	S.actno=123;
	S.bal=3000;
	S.deposit(2000);
	C.actno=224;
	C.bal=2000;
	C.deposit(500);
	return 0;
}
