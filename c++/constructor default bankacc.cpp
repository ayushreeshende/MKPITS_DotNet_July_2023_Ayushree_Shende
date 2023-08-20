#include<iostream>
using namespace std;
class bankaccount
{
	public:
		int accno,balance;
		int getdeposit();
bankaccount()
		{
			accno=0;
			balance=0;
		}
			 int getdeposite()
			 {
			 
			
			int amt;
			cout<<"emter deposite amt:";
			cin>>amt;
			balance=balance+amt;
			cout<<"amount deposited:"<<balance<<endl;
			return amt;
		}
		int getwithdrawal()
		{
			int amt;
			cout<<"enter withdrawal amt:";
			cin>>amt;
			balance=balance-amt;
			cout<<"amount withdrawal:"<<balance<<endl;
			return amt;
		}
};
int main()
{
	bankaccount b1;
	cout<<"enter accno and balance:";
	cin>>b1.accno>>b1.balance;
	b1.getdeposite();
	b1.getwithdrawal();
	return 0;
}


