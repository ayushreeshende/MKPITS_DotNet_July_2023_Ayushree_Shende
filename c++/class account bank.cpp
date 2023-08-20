#include<iostream>
using namespace std;
class bankaccount
{
	public:
		int accno,balance;
		int getdeposite()
		{
			int amt;
			cout<<"emter deposit amt:";
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
	cout<<"enter account no and balance:";
	cin>>b1.accountno>>b1.balance;
	b1.getdeposit();
	b1.getwithdrawal();
	return 0;
}

