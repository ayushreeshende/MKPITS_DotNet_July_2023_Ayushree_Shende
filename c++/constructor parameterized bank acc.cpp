#include<iostream>
using namespace std;
class bankaccount
{
	public:
		int accno,balance;
		int getdeposit();
bankaccount(int accno,int balance)
		{
			accno=accno;
			balance=balance;
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
	int accno,balance,
	 
	 bankaccount
	cout<<"enter accno and balance:";
	cin>>accno>>balance;
getdeposite();
getwithdrawal();
	return 0;
}


